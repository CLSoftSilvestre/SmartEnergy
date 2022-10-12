using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnergyModels.CompressedAir
{
    class AirCompressor : SmartEnergyModel
    {
        public bool Oil_Free_Compressor { get; set; }
        public bool VSD_Compressor { get; set; }
        public AirCompressorProcess ProcessData { get; set; }
        public AirCompressorEngineering EngineeringData { get; set; }
        public AirCompressorPerformance PerformanceData { get; set; }
    }

    class AirCompressorPerformance
    {
        public float Nominal_Power { get; set; }
        public float Nominal_Flow { get; set; }
        public float Nominal_Pressure { get; set; }
        public float Nominal_Specific_Consumption { get; set; }
        public float Instant_Specific_Consumption { get; set; }
    }

    class AirCompressorEngineering
    {
        public float Air_Inlet_Temperature { get; set; }
        public float Element1_Outlet_Temperature { get; set; }
        public float Element2_Intlet_Temperature { get; set; }
        public float Element2_Outlet_Temperature { get; set; }
        public float Air_Outlet_Temperature { get; set; }
        public float Oil_Pressure { get; set; }
        public float Oil_Temperature { get; set; }
        public float Filter_Pressure_Drop { get; set; }
        public float Intercoller_Pressure { get; set; }
    }

    class AirCompressorProcess{
        public AirCompressorStatus Status { get; set; }
        public AirCompressorMode Mode { get; set; }
        public float Pressure_Setpoint { get; set; }
        public float Instant_Pressure { get; set; }
        public float Instant_Power_Consumption { get; set; }
        public float Instant_Flow { get; set; }
        public float Motor_Speed { get; set; }
    }

    enum AirCompressorMode
    {
        Stopped,
        Idle,
        Production,
        Maintenance
    }

    enum AirCompressorStatus
    {
        Idle,
        Running,
        Stopped
    }

}
