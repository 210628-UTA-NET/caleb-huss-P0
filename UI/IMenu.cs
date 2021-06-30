namespace UI
{
    public enum MenuType
    {
        MainMenu,
        AddCustomerMenu,
        CustomerMenu,
        CustomerSearchMenu,
        OrderHistoryMenu,
        PlaceOrderMenu,
        ReplenishInventoryMenu,
        ViewInventoryMenu,
        Exit
    }
    public interface IMenu
    {

        /// <summary>
        /// Will display the menu for the given class
        /// </summary>
        void Menu();
        /// <summary>
        /// Will take in the users choice and return the menu based on that
        /// </summary>
        /// <returns>Returns what menu to go to</returns>
        MenuType YourChoice();
    }
}