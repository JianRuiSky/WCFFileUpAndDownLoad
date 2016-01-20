using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataRcvService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IDataRcvService”。
    [ServiceContract]
    public interface IDataRcvService
    {
        [OperationContract]
        bool DoWork(DateTime dt);
        [OperationContract]
        UpFileResult UpLoadFile(UpFile filestream);
        [OperationContract]
        DownFileResult DownLoadFile(DownFile downfile);
    }
}
