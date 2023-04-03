using BlueHardwareInfo.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BlueHardwareInfo.Core
{
    public class HardwareInfo
    {
        /// <summary>
        /// represents an information about cpu
        /// </summary>
        /// <returns>CpuInformationEntity</returns>
        public async Task<CpuInformationEntity> GetCpuInformationAsync()
        {
            TaskCompletionSource<CpuInformationEntity> completionSource = new TaskCompletionSource<CpuInformationEntity>();
            try
            {
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(@"root\CIMV2", "SELECT * FROM Win32_Processor");
                
                foreach (var query in searcher.Get())
                {
                    var entity = new CpuInformationEntity()
                    {
Architecture =(string) query.GetPropertyValue("Architecture"),
L2CacheSize = Convert.ToInt32(query.GetPropertyValue("L2CacheSize")),
MaxClockSpeed = Convert.ToInt32(query.GetPropertyValue("MaxClockSpeed")),
Family = (string) query.GetPropertyValue("Family"),
Name = (string) query.GetPropertyValue("Name"),
NumberOfCores = Convert.ToInt32(query.GetPropertyValue("NumberOfCores")),
NumberOfLogicalProcessors = Convert.ToInt32(query.GetPropertyValue("NumberOfLogicalProcessors")),
ProcessorId = (string) query.GetPropertyValue("ProcessorId")
                    };
                    completionSource.SetResult(entity);
                } //end for.each
            } //end try
            catch (Exception e)
            {

                completionSource.SetException(e);
            }//end catch
            return await completionSource.Task;
        } //end method
    }
}
