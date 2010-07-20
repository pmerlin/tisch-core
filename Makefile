# TISCH Framework: master Makefile

# check if global config already defined
ifndef TISCH_CONFIG

  TOPDIR   = $(shell pwd)
  DESTDIR ?= $(TOPDIR)/build/
  PREFIX  ?= /usr
  BINDIR   = $(DESTDIR)/bin/
  LIBDIR   = $(DESTDIR)/lib/
  INCDIR   = $(DESTDIR)/include/libtisch/
  DOCDIR   = $(DESTDIR)/share/doc/libtisch/
  SHARED   = $(DESTDIR)/share/libtisch/

  CFLAGS  += -Wall -ggdb -fPIC -DTISCH_SHARED="" -DTIXML_USE_STL -I. -DTISCH_PREFIX='"$(PREFIX)/share/libtisch/"'
  LDFLAGS += -Wall -ggdb -L$(LIBDIR) $(shell pkg-config --libs libdc1394-2 2> /dev/null) $(shell pkg-config --libs libv4l2 2> /dev/null)
  SLFLAGS += -Wall -ggdb -fPIC -L$(LIBDIR)

  OS = $(shell uname)
  TISCH_CONFIG = 1

  ifeq ($(OS),Linux)

    ifeq (dc1394,$(findstring dc1394,$(LDFLAGS)))
      CFLAGS += -DHAS_DC1394
    endif
    ifeq (v4l2,$(findstring v4l2,$(LDFLAGS)))
      CFLAGS += -DHAS_LIBV4L
    endif
    LDFLAGS += -lGL -lGLU -lglut
    SLFLAGS += -shared
    CFLAGS  += -O2 -fno-strict-aliasing
    SUFFIX = so
    LSF = so.1.1

  else ifeq ($(OS),Darwin)

    ifeq (arm-apple-darwin9,$(shell $(CXX) -dumpmachine))
      LDFLAGS += -lobjc -framework Foundation -framework CoreFoundation -framework CoreGraphics -framework CoreSurface -framework GraphicsServices -framework QuartzCore -framework OpenGLES -framework UIKit -bind_at_load -multiply_defined suppress -F/System/Library/PrivateFrameworks
      CFLAGS  += -DTISCH_IPHONE
      OS = iPhone
    else
      LDFLAGS += -framework OpenGL -framework GLUT -arch i386
      CFLAGS  += -O2 -fno-strict-aliasing -arch i386
      OS = MacOSX
    endif
    SLFLAGS += -dynamiclib
    SUFFIX = dylib
    LSF = dylib

  endif

endif

# export global config variables
export TOPDIR BINDIR LIBDIR INCDIR DOCDIR SHARED OS SUFFIX LSF CFLAGS LDFLAGS SLFLAGS TISCH_CONFIG


# info blurb
default:
	@echo
	@echo TISCH Framework - http://tisch.sourceforge.net/
	@echo
	@echo Copyright '(c)' 2006-2010 by Florian Echtler, TUM '<echtler@in.tum.de>'
	@echo Licensed under GNU Lesser General Public License '(LGPL)' 3 or later  
	@echo
	@echo Please choose one of the following targets:
	@echo 
	@echo "  all      - build all binaries"
	@echo "  libtisch - build libTISCH targets"
	@echo "  wrappers - build C#/Java/Python wrappers"
	@echo "  install  - install all binaries into $(DESTDIR)"
	@echo "  clean    - remove all binaries"
	@echo
	@echo "  additional targets: $(TARGETS) $(WRAPPERS)"
	@echo
	@echo If you need special include/library paths, put them into the 
	@echo CFLAGS and LDFLAGS environment variables. To choose a different
	@echo installation target, set the DESTDIR variable. Example:
	@echo
	@echo "  make CFLAGS=-I/opt/include DESTDIR=/usr/local/ install"
	@echo


# target directories
TARGETS = libs/tools libs/simplegl gestured widgets

ifneq ($(OS),iPhone)
  TARGETS += libs/simplecv drivers/touchd drivers/tuio calibd
endif

ifneq ($(shell which gmcs),)
  WRAPPERS += libs/wrappers/csharp
endif

ifneq ($(shell which javac),)
  WRAPPERS += libs/wrappers/java
endif

ifneq ($(shell which python),)
  WRAPPERS += libs/wrappers/python
endif


# phony declarations
.PHONY: default all install wrappers clean $(TARGETS) $(WRAPPERS)


# dependencies
ifneq ($(COMMAND),clean)
  libs/simplecv: libs/tools
  libs/simplegl: libs/simplecv
  drivers/touchd calibd: libs/simplegl
  drivers/tuio gestured: libs/tools
  widgets: libs/simplegl gestured
  $(WRAPPERS): widgets
endif


# aliases
simplecv: libs/simplecv
simplegl: libs/simplegl
touchd: drivers/touchd
tuio:   drivers/tuio
tools: libs/tools

csharp: libs/wrappers/csharp
java: libs/wrappers/java
python: libs/wrappers/python


# top-level targets
all: libtisch wrappers
libtisch: $(TARGETS)
wrappers: $(WRAPPERS)

install:
	$(MAKE) COMMAND=install all

clean:
	$(MAKE) COMMAND=clean all

$(TARGETS) $(WRAPPERS):
	$(MAKE) -C $@ $(COMMAND)
