TOPDIR = ../
CFLAGS += -I$(TOPDIR)/libs/osc/ -I$(TOPDIR)/libs/tools/ -I$(TOPDIR)/libs/simplecv/ -I$(TOPDIR)/libs/simplegl/ -I$(TOPDIR)/gispl/ -I$(TOPDIR)/gispl/features/ -I$(TOPDIR)
LDFLAGS += -loscpack -ltools -lsimplecv -lsimplegl -lgispl -L$(TOPDIR)/libs/osc/ -L$(TOPDIR)/libs/tools/ -L$(TOPDIR)/libs/simplecv/ -L$(TOPDIR)/libs/simplegl/ -L$(TOPDIR)/gispl/

APPS = picview demo graph slideshow gispl
MORE = *.png
INCS = *.h
LIBS = libwidgets.$(LSF)
OBJS = Window.o Container.o Button.o Tile.o MasterContainer.o Dial.o Textbox.o Slider.o Checkbox.o Label.o Map.o Mouse.o Widget.o

include $(TOPDIR)/scripts/rules.mk

