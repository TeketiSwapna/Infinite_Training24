using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RailwayReservation
{
    class Program
    {
        //object of the context class
        static RailwayReservationEntities db = new RailwayReservationEntities();
        private static readonly string connectionString = "Server=ICS-LT-CRY19C3;Database=RailwayReservation;integrated security = true;";
        static void Main(string[] args)
        {
            Console.WriteLine("                                     WELCOME TO RAILWAY RESERVATION SYSTEM                              ");
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. User");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                var roleChoice = Console.ReadLine();
                switch (roleChoice)
                {
                    case "1":
                        AdminMenu();
                        break;
                    case "2":
                        UserMenu();
                        break;
                    case "3":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
                        break;
                }
            }
        }
        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\nAdmin Menu:");
                Console.WriteLine("1. Add a new train");
                Console.WriteLine("2. Update a train");
                Console.WriteLine("3. Delete a train");
                Console.WriteLine("4. View all trains");
                Console.WriteLine("5. View all cancelled tickets");
                Console.WriteLine("6. Exit to main menu");
                Console.Write("Enter your choice (1-6): ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewTrain();
                        break;
                    case "2":
                        UpdateTrain();
                        break;
                    case "3":
                        DeleteTrain();
                        break;
                    case "4":
                        ViewAllTrains();
                        break;
                    case "5":
                        ViewCancelledTrains();
                        break;
                    case "6":
                        Console.WriteLine("Exiting to main menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                        break;
                }
            }
        }
        static void UserMenu()
        {
            while (true)
            {
                Console.WriteLine("\nUser Menu:");
                Console.WriteLine("1. Book seats");
                Console.WriteLine("2. Cancel booking");
                Console.WriteLine("3. View all trains");
                Console.WriteLine("4. Exit to main menu");
                Console.Write("Enter your choice (1-4): ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        ViewAllTrains();
                        BookSeats();
                        break;
                    case "2":
                        ViewBookedTickets();
                        CancelBooking();
                        break;
                    case "3":
                        Console.WriteLine("View all trains...");
                        return;
                    case "4":
                        Console.WriteLine("Exiting to main menu...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                        break;
                }
            }
        }
        // Method to view all trains
        static void ViewAllTrains()
        {
            Console.WriteLine("\nViewing All Trains");
            Console.WriteLine("=================");
            var trains = db.Trains.ToList();
            if (trains.Count == 0)
            {
                Console.WriteLine("No trains available.");
                return;
            }

            foreach (var train in trains)
            {
                Console.WriteLine($"Train Number: {train.TrainNumber}, Train Name: {train.TrainName}, From: {train.FromDestination}, To: {train.ToDestination}, Price: {train.Price}, Class: {train.ClassOfTravel}, Status: {train.TrainStatus}, Seats Available: {train.SeatsAvailable}");
            }
        }
        // Method to view booked tickets
        static void ViewBookedTickets()
        {
            Console.WriteLine("\nViewing Booked Tickets");
            Console.WriteLine("======================");

            var bookings = db.Bookings.ToList();

            if (bookings.Count == 0)
            {
                Console.WriteLine("No bookings found.");
                return;
            }

            foreach (var booking in bookings)
            {
                Console.WriteLine($"Booking ID: {booking.BookingId}, Train Number: {booking.TrainNumber}, Class: {booking.ClassOfTravel}, Seats: {booking.NumberOfSeats}, Booking Date: {booking.BookingDate}");
            }
        }
        static void AddNewTrain()
        {
            Console.WriteLine("\nAdding a New Train");
            Console.WriteLine("==================");

            Console.Write("Enter Train Number: ");
            if (!int.TryParse(Console.ReadLine(), out int trainNumber))
            {
                Console.WriteLine("Invalid input for Train Number. Aborting operation.");
                return;
            }

            Console.Write("Enter Train Name: ");
            var trainName = Console.ReadLine();

            Console.Write("Enter From Destination: ");
            var fromDestination = Console.ReadLine();

            Console.Write("Enter To Destination: ");
            var toDestination = Console.ReadLine();

            Console.Write("Enter Price: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal price))
            {
                Console.WriteLine("Invalid input for price. Aborting operation.");
                return;
            }

            Console.Write("Enter Class of Travel: ");
            var classOfTravel = Console.ReadLine();

            Console.Write("Enter Train Status: ");
            var trainStatus = Console.ReadLine();

            Console.Write("Enter Seats Available: ");
            if (!int.TryParse(Console.ReadLine(), out int seatsAvailable))
            {
                Console.WriteLine("Invalid input for seats available. Aborting operation.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("AddTrain", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TrainNumber", trainNumber));
                command.Parameters.Add(new SqlParameter("@TrainName", trainName));
                command.Parameters.Add(new SqlParameter("@FromDestination", fromDestination));
                command.Parameters.Add(new SqlParameter("@ToDestination", toDestination));
                command.Parameters.Add(new SqlParameter("@Price", price));
                command.Parameters.Add(new SqlParameter("@ClassOfTravel", classOfTravel));
                command.Parameters.Add(new SqlParameter("@TrainStatus", trainStatus));
                command.Parameters.Add(new SqlParameter("@SeatsAvailable", seatsAvailable));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("New train added successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error adding new train: {ex.Message}");
                }
            }
        }
        static void UpdateTrain()
        {
            Console.WriteLine("\nUpdating a Train");
            Console.WriteLine("================");
            Console.Write("Enter Train Number to update: ");
            if (!int.TryParse(Console.ReadLine(), out int trainNumber))
            {
                Console.WriteLine("Invalid input for Train Number. Aborting operation.");

                return;
            }
            // Check if the entered train number exists in the database
            var existingTrain = db.Trains.FirstOrDefault(t => t.TrainNumber == trainNumber);
            if (existingTrain == null)
            {
                Console.WriteLine($"Train with Train Number {trainNumber} does not exist.");
                return;
            }
            Console.Write("Enter New Train Name (leave empty to keep current): ");
            var newTrainName = Console.ReadLine();
            Console.Write("Enter New Price (leave empty to keep current): ");
            var newPriceInput = Console.ReadLine();
            decimal? newPrice = null;
            if (!string.IsNullOrEmpty(newPriceInput) && decimal.TryParse(newPriceInput, out decimal parsedPrice))
            {
                newPrice = parsedPrice;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("UpdateTrain", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TrainNumber", trainNumber));
                command.Parameters.Add(new SqlParameter("@TrainName", newTrainName ?? (object)DBNull.Value));
                command.Parameters.Add(new SqlParameter("@Price", newPrice ?? (object)DBNull.Value));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Train updated successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error updating train: {ex.Message}");
                }
            }
        }
        static void DeleteTrain()
        {
            Console.WriteLine("\nDeleting a Train");
            Console.WriteLine("================");
            Console.Write("Enter Train Number to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int trainNumber))
            {
                Console.WriteLine("Invalid input for Train Number. Aborting operation.");
                return;
            }
            // Check if the train with the given trainNumber exists in the database
            var trainToDelete = db.Trains.FirstOrDefault(t => t.TrainNumber == trainNumber);
            if (trainToDelete == null)
            {
                Console.WriteLine($"Train with Train Number {trainNumber} does not exist.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("DeleteTrain", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@TrainNumber", trainNumber));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Train deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting train: {ex.Message}");
                }
            }
        }
        // Method to book seats with bulk booking (max 3 seats per booking)
        static void BookSeats()
        {
            Console.WriteLine("\nBooking Seats");
            Console.WriteLine("============");

            Console.Write("Enter Train Number to book seats: ");
            if (!int.TryParse(Console.ReadLine(), out int trainNumber))
            {
                Console.WriteLine("Invalid input for Train Number. Aborting operation.");
                return;
            }
            var trainForBooking = db.Trains.Find(trainNumber);
            if (trainForBooking == null)
            {
                Console.WriteLine("Train not found.");
                return;
            }
            Console.Write("Enter Class of Travel: ");
            var classOfTravel = Console.ReadLine();
            Console.Write("Enter Number of Seats to book (max 3): ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfSeats) || numberOfSeats <= 0 || numberOfSeats > 3)
            {
                Console.WriteLine("Invalid input for number of seats. Maximum 3 seats can be booked per transaction. Aborting operation.");
                return;
            }
            if (trainForBooking.SeatsAvailable < numberOfSeats)
            {
                Console.WriteLine("Not enough seats available.");
                return;
            }
            var newBooking = new Booking
            {
                TrainNumber = trainForBooking.TrainNumber,
                ClassOfTravel = classOfTravel,
                NumberOfSeats = numberOfSeats,
                BookingDate = DateTime.Now
            };
            try
            {
                db.Bookings.Add(newBooking);
                db.SaveChanges();
                trainForBooking.SeatsAvailable -= numberOfSeats;
                db.SaveChanges();
                Console.WriteLine($"Seats booked successfully. Booking ID: {newBooking.BookingId}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error booking seats: {ex.Message}");
            }
        }
        static void ViewCancelledTrains()
        {
            Console.WriteLine("\nCancelled Trains");
            Console.WriteLine("================");
            using (var db = new RailwayReservationEntities())
            {
                var cancelledTrains = from cancellation in db.Cancellations
                                      join booking in db.Bookings on cancellation.BookingId equals booking.BookingId
                                      join train in db.Trains on booking.TrainNumber equals train.TrainNumber
                                      select new
                                      {
                                          TrainNumber = train.TrainNumber,
                                          TrainName = train.TrainName,
                                          FromDestination = train.FromDestination,
                                          ToDestination = train.ToDestination,
                                          ClassOfTravel = booking.ClassOfTravel,
                                          NumberOfSeatsCancelled = cancellation.NumberOfSeatsCancelled,
                                          CancellationDate = cancellation.CancellationDate
                                      };

                Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-15} {5,-10} {6,-20}",
                    "TrainNumber", "Train Name", "From", "To", "Class", "Seats Cancelled", "Cancellation Date");

                foreach (var train in cancelledTrains)
                {
                    string cancellationDateStr = train.CancellationDate.HasValue
                        ? train.CancellationDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
                        : "N/A"; // Use "N/A" if CancellationDate is null

                    Console.WriteLine("{0,-10} {1,-20} {2,-20} {3,-20} {4,-15} {5,-10} {6,-20}",
                        train.TrainNumber, train.TrainName, train.FromDestination, train.ToDestination,
                        train.ClassOfTravel, train.NumberOfSeatsCancelled, cancellationDateStr);
                }
            }
        }
        static void CancelBooking()
        {
            Console.WriteLine("\nCancel Booking");
            Console.WriteLine("==============");

            Console.Write("Enter Booking ID to cancel: ");
            if (!int.TryParse(Console.ReadLine(), out int bookingId))
            {
                Console.WriteLine("Invalid input for Booking ID. Aborting operation.");
                return;
            }
            Console.Write("Enter Number of Seats to cancel: ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfSeatsCancelled))
            {
                Console.WriteLine("Invalid input for number of seats to cancel. Aborting operation.");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("CancelBooking", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@BookingId", bookingId));
                command.Parameters.Add(new SqlParameter("@NumberOfSeatsCancelled", numberOfSeatsCancelled));
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Booking cancelled successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error cancelling booking: {ex.Message}");
                }
            }
        }
    }
}
