using System;
using System.Collections.Generic;
using BL;
using Models;

namespace UI
{
    
    public class ViewInventoryMenu : IMenu
    {
        private IInventoryBL _invBL;
        public ViewInventoryMenu(IInventoryBL p_invBL)
        {
            _invBL = p_invBL;
        }
        public void Menu()
        {
            throw new NotImplementedException();
        }

        public MenuType YourChoice()
        {
            throw new NotImplementedException();
        }
    }
}