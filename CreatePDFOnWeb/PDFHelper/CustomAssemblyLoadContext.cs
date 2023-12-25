using System.Reflection;
using System.Runtime.Loader;

namespace CreatePDFOnWeb.PDFHelper
{
    public class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        public nint LoadUnmanagedLibrary(string absolutePath)
        {
            return LoadUnmanagedDll(absolutePath);
        }

        protected override nint LoadUnmanagedDll(string unmanagedDllName)
        {
            return LoadUnmanagedDllFromPath(unmanagedDllName);
        }
    }
}