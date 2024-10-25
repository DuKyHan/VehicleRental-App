namespace VehicleRentalService
{
    public interface IBookAndRent
    {
        Vehicle ChooseVehicle();

        Customer CreateCustomer();

        Book CreateBook(Customer customer, Vehicle vehicle);
    }
}