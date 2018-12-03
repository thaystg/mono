thisdir = class/System.Net.Http.SocketsHttpHandler
SUBDIRS = FunctionalTests UnitTests
include ../../build/rules.make

LIBRARY = System.Net.Http.SocketsHttpHandler.dll
LIB_REFS = System
KEYFILE = ../msfinal.pub
LIB_MCS_FLAGS = /unsafe /nowarn:436

TEST_LIB_REFS = System System.Core

XTEST_LIB_REFS = System System.Core Facades/System.Threading.Tasks

include ../../build/library.make

clean-local:
	-rm -f $(tests_CLEAN_FILES) $(library_CLEAN_FILES) $(CLEAN_FILES)


