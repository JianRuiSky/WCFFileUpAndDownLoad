using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataRcvService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“DataRcvService”。
    public class DataRcvService : IDataRcvService
    {
        /// <summary>
        /// 告诉client今天是否有增量文件
        /// client的算法如下
        /// 有增量文件，则开始请求后续判断
        /// 无增量文件，则继续请求该接口
        /// </summary>
        /// <param name="dt">客户端通过检查本地的文件夹，并把时间传输过来</param>
        /// <returns></returns>
        public bool DoWork(DateTime dt)
        {
            throw new NotImplementedException();
        }


        public UpFileResult UpLoadFile(UpFile filedata)
        {
            UpFileResult result = new UpFileResult();
            string path = System.AppDomain.CurrentDomain.BaseDirectory + @"\service\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            byte[] buffer = new byte[filedata.FileSize];
            FileStream fs = new FileStream(path + filedata.FileName, FileMode.Create, FileAccess.Write);
            int count = 0;
            while ((count = filedata.FileStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                fs.Write(buffer, 0, count);
            }
            //清空缓冲区
            fs.Flush();
            //关闭流
            fs.Close();
            result.IsSuccess = true;
            return result;
        }

        public DownFileResult DownLoadFile(DownFile filedata)
        {
            DownFileResult result = new DownFileResult();
            string path = System.AppDomain.CurrentDomain.BaseDirectory + @"\service\" + filedata.FileName;
            if (!File.Exists(path))
            {
                result.IsSuccess = false;
                result.FileSize = 0;
                result.Message = "服务器不存在此文件";
                result.FileStream = new MemoryStream();
                return result;
            }
            Stream ms = new MemoryStream();
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            fs.CopyTo(ms);
            ms.Position = 0;  //重要，不为0的话，客户端读取有问题
            result.IsSuccess = true;
            result.FileSize = ms.Length;
            result.FileStream = ms;
            fs.Flush();
            fs.Close();
            return result;
        }
    }
}
