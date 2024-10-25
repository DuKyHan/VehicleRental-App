using System;

namespace VehicleRentalService
{
    public class ServiceHistory
    {
        private string _vehicleId;
        private double _travelledDistanceAtMaintenance;
        private DateTime _date;
        private MaintenanceType _maintenanceType;

        public ServiceHistory(string vehicleId, double travelledDistance, DateTime date,
            MaintenanceType maintenanceType)
        {
            _vehicleId = vehicleId;
            _travelledDistanceAtMaintenance = travelledDistance;
            _date = date;
            _maintenanceType = maintenanceType;
        }


        public static double operator -(ServiceHistory sh1, ServiceHistory sh2)
        {
            return Math.Abs(sh1._travelledDistanceAtMaintenance - sh2._travelledDistanceAtMaintenance);
        }

        public static bool operator <(ServiceHistory sh1, ServiceHistory sh2)
        {
            return sh1._date < sh2._date;
        }

        public static bool operator >(ServiceHistory sh1, ServiceHistory sh2)
        {
            return sh1._date > sh2._date;
        }

        public static bool operator ==(ServiceHistory sh1, ServiceHistory sh2)
        {
            return sh1._date == sh2._date;
        }

        public static bool operator !=(ServiceHistory sh1, ServiceHistory sh2)
        {
            return sh1._date != sh2._date;
        }

        public string GetVehicleId()
        {
            return _vehicleId;
        }

        public double GetTravelledDistance()
        {
            return _travelledDistanceAtMaintenance;
        }

        public DateTime GetDate()
        {
            return _date;
        }

        public MaintenanceType GetMaintenanceType()
        {
            return _maintenanceType;
        }
    }

    public enum MaintenanceType
    {
        EngineOilChange,
        EngineMinor,
        EngineMajor,
        
        TransmissionFluidChange,
        TransmissionMinor,
        TransmissionOverhaul,
        
        TiresAdjustment,
        TiresReplacement,
    }
}