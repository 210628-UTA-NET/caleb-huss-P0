using System;
using Models;
using System.Collections.Generic;

namespace BL
{   
    /// <summary>
    /// This will handle all the BL for the storefront model
    /// </summary>
    public interface IStoreBL
    {
        /// <summary>
        /// Gets all the customers from the database via the DL
        /// </summary>
        /// <returns>Returns a list of all the stores</returns>
        List<StoreFront> GetAllStores();
        /// <summary>
        /// Adds a customer to the db via the DL
        /// </summary>
        /// <param name="p_store">This obj represents the store being added</param>
        /// <returns>returns the store added</returns>
        StoreFront AddStore(StoreFront p_store);
    }
}