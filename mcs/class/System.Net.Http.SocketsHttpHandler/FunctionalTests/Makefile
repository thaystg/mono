thisdir = class/System.Net.Http.SocketsHttpHandler/FunctionalTests
SUBDIRS = 
include ../../../build/rules.make

ASSEMBLY = System.Net.Http.FunctionalTests

XTEST_LIB_REFS = System System.Core Facades/System.Threading.Tasks
USE_XTEST_REMOTE_EXECUTOR = YES
DOTNET_URI = 1

XTEST_LIB_FLAGS = /resource:../TestData/testservereku.contoso.com.pfx

the_assembly = $(topdir)/class/lib/$(PROFILE_DIRECTORY)/System.Net.Http.SocketsHttpHandler.dll

include ../../../build/tests.make

DOTNET_URI = 1

clean-local:
	-rm -f $(tests_CLEAN_FILES) $(CLEAN_FILES)

