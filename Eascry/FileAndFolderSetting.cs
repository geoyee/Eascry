using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace Eascry
{
    class FileAndFolderSetting
    {
        //创建base64编码文件
        public static void CreateBase64File(string base64, string path)
        {
            StreamWriter sw;

            sw = File.CreateText(path);
            sw.Close();

            using (FileStream userWrite = new FileStream(path, FileMode.Open, FileAccess.Write))
            {
                StreamWriter stw = new StreamWriter(userWrite, Encoding.GetEncoding("utf-8"));

                stw.WriteLine(base64);

                stw.Close();
            }
        }

        //判断set文件是否存在，不存在就新建
        public static void AddSet(string path)
        {
            if (!File.Exists(path))  //如果文件不存在,则创建文件
            {
                StreamWriter sw;

                sw = File.CreateText(path);
                AddSecurityControllToFile(path);
                sw.Close();
            }
        }

        //解决用户安装到C盘没有权限的问题
        public static void AddSecurityControllToFile(string filePath)
        {
            //获取文件信息
            FileInfo fileInfo = new FileInfo(filePath);
            //获得该文件的访问权限
            System.Security.AccessControl.FileSecurity fileSecurity = fileInfo.GetAccessControl();
            //添加ereryone用户组的访问权限规则 完全控制权限
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            //添加Users用户组的访问权限规则 完全控制权限
            fileSecurity.AddAccessRule(new FileSystemAccessRule("Users", FileSystemRights.FullControl, AccessControlType.Allow));
            //设置访问权限
            fileInfo.SetAccessControl(fileSecurity);
        }

        public static void AddSecurityControllToFolder(string dirPath)
        {
            //获取文件夹信息
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            //获得该文件夹的所有访问权限
            System.Security.AccessControl.DirectorySecurity dirSecurity = dir.GetAccessControl(AccessControlSections.All);
            //设定文件ACL继承
            InheritanceFlags inherits = InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit;
            //添加ereryone用户组的访问权限规则 完全控制权限
            FileSystemAccessRule everyoneFileSystemAccessRule = new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);
            //添加Users用户组的访问权限规则 完全控制权限
            FileSystemAccessRule usersFileSystemAccessRule = new FileSystemAccessRule("Users", FileSystemRights.FullControl, inherits, PropagationFlags.None, AccessControlType.Allow);

            bool isModified = false;
            dirSecurity.ModifyAccessRule(AccessControlModification.Add, everyoneFileSystemAccessRule, out isModified);
            dirSecurity.ModifyAccessRule(AccessControlModification.Add, usersFileSystemAccessRule, out isModified);
            //设置访问权限
            dir.SetAccessControl(dirSecurity);
        }
    }
}
