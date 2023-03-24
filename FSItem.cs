using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder
{
    /// <summary>
    /// Simple wrapper for file/dir info objects to facilitate viewing them in an ObjectListView
    /// </summary>
    public class FSItem
    {
        private FileSystemInfo _fsInfo;
        public FSItem(FileInfo finfo) { _fsInfo = finfo; }
        public FSItem(DirectoryInfo dinfo) { _fsInfo = dinfo; }
        public string Name { get { return _fsInfo.Name; } set { } }
        public string Type
        {
            get
            {
                if (_fsInfo is FileInfo)
                {
                    FileInfo finfo = _fsInfo as FileInfo;
                    if (finfo.Extension.Length == 0) return "(none)";
                    else return finfo.Extension;
                }
                else
                    return "(dir)";
            }
            set { }
        }
        public string Path { get { return _fsInfo.FullName.Substring(0, _fsInfo.FullName.LastIndexOf("\\") + 1); } set { } }
        public long Size
        {
            get
            {
                if (_fsInfo is FileInfo)
                    return ((FileInfo)_fsInfo).Length;
                else
                    return 0;
            }
            set { }
        }
        public DateTime DateModified { get { return _fsInfo.LastWriteTime; } set { } }
        public DateTime DateCreated { get { return _fsInfo.CreationTime; } set { } }
        public override string ToString() { return _fsInfo.FullName; }
        public bool IsFile() {  return _fsInfo is FileInfo; }
        public bool IsDir() { return _fsInfo is DirectoryInfo; }
    }
}
