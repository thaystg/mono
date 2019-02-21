using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Reflection
{
	[StructLayout (LayoutKind.Sequential)]
	partial class Assembly
	{
		public static Assembly Load (string assemblyString)
		{
			if (assemblyString == null)
				throw new ArgumentNullException (nameof (assemblyString));

			var name = new AssemblyName (assemblyString);
			return Load (name, IntPtr.Zero);
		}

		public static Assembly Load (AssemblyName assemblyRef)
		{
			if (assemblyRef == null)
				throw new ArgumentNullException (nameof (assemblyRef));

			return Load (assemblyRef, IntPtr.Zero);
		}

		internal static Assembly Load (AssemblyName assemblyRef, IntPtr ptrLoadContextBinder)
		{
			throw new NotImplementedException ();
		}

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public static extern Assembly GetExecutingAssembly ();

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public static extern Assembly GetCallingAssembly ();

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		public static extern Assembly GetEntryAssembly ();

		internal bool IsRuntimeImplemented () => this is RuntimeAssembly;

		internal virtual IntPtr MonoAssembly {
			get {
				throw new NotImplementedException ();
			}
		}

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern Type InternalGetType (Module module, string name, bool throwOnError, bool ignoreCase);

		[MethodImplAttribute (MethodImplOptions.InternalCall)]
		internal extern static void InternalGetAssemblyName (string assemblyFile, out Mono.MonoAssemblyName aname, out string codebase);

		#region to be removed

		public static Assembly LoadFrom (string assemblyFile)
		{
			throw new NotImplementedException ();
		}

		public static Assembly Load (byte[] rawAssembly, byte[] rawSymbolStore)
		{
			throw new NotImplementedException ();
		}

		public static Assembly LoadFile (string path) { throw null; }

		public static Assembly LoadFrom (string assemblyFile, byte[] hashValue, System.Configuration.Assemblies.AssemblyHashAlgorithm hashAlgorithm) { throw null; }
		
		#endregion
	}
}