include $(topdir)/build/profiles/net_4_x.make

PLATFORMS =

PROFILE_MCS_FLAGS = -d:NET_4_0 -d:NET_4_5 -d:NET_4_6 -d:MONO -nowarn:1699 -nostdlib $(PLATFORM_DEBUG_FLAGS) \
	-d:FEATURE_INTERCEPTABLE_THREADPOOL_CALLBACK \
	-d:NO_SYSTEM_DRAWING_DEPENDENCY \
	-d:NO_WINFORMS_DEPENDENCY \
	-d:NO_SYSTEM_WEB_DEPENDENCY \
	-d:XAMMAC_4_5 \
	-d:XAMARIN_MODERN \
	$(XAMMAC_MCS_FLAGS)

XAMMAC_4_5=1
NO_WINDOWS_BASE=1
NO_SYSTEM_WEB_DEPENDENCY=1
NO_SYSTEM_WEB_APPSERVICES_DEPENDENCY=1
NO_WINFORMS_DEPENDENCY=1
NO_SYSTEM_DRAWING_DEPENDENCY=1
NO_SYSTEM_SERVICEMODEL_ACTIVATION_DEPENDENCY=1
NO_SYSTEM_DESIGN_DEPENDENCY=1
NO_SYSTEM_DIRECTORY_SERVICES_DEPENDENCY=1
PROFILE_DISABLE_BTLS=1
MONO_FEATURE_APPLETLS=1
ONLY_APPLETLS=1
ENABLE_GSS=1

PROFILE_TEST_HARNESS_EXCLUDES += InetAccess
