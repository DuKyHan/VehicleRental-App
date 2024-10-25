namespace VehicleRentalService
{
    public interface IVehicleMaintenance
    {
        void ServiceFleet();
        void ServiceFleetEngine();
        void ServiceFleetTransmission();
        void ServiceFleetTires();
    }
}