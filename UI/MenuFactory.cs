using BL;
using DL;

namespace UI
{
    public class MenuFactory : IFactory
    {
        public IMenu GetMenu(MenuType p_menu)
        {
            switch (p_menu)
            {

                default:
                    return null;
            }
        }
    }
}