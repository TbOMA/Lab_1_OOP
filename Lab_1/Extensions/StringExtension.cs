using Lab_1.Models;
namespace Lab_1.Extensions
{
    public static class StringExtension
    {
        public static string ToString(this PersonVm vm)
        {
            return $"{vm.Address}, {vm.SecondName},{vm.FirstName},{vm.PhoneNumber}";
        }
    }
}
