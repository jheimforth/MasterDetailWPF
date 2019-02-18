using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPF_MasterDetailApp;
using WPF_MasterDetailApp.Models;

namespace WPF_MasterDetailApp.BusinessLayer
{
    public class ProductBL
    {
        #region ENUMS



        #endregion

        #region FIELDS
        ProductWindowView _productWindowView;
        ProductWindowPresenter _ProductWindowPresenter;


        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS
        public ProductBL()
        {
            _ProductWindowPresenter = new ProductWindowPresenter(GetCompanyData(), GetProductData());

            _productWindowView = new ProductWindowView(_ProductWindowPresenter);
            _productWindowView.DataContext = _ProductWindowPresenter;
            _productWindowView.Show();
        }


        #endregion

        #region METHODS
        private Company GetCompanyData()
        {
            return new Company()
            {
                Name = "Infinite Music Record Company",
                Address = "224 8th street",
                City = "Traverse City"
            };
        }

        private Product GetProductData()
        {
            return new Product()
            {
                AlbumName = "The Discovery",
                ArtistName = "Born of Osiris",
                Genre = "Metal",
                Format = "CD",
                Runtime = 41,
                Price = 9.99,
                ReleaseYear = 2011
            };
        }



        #endregion

        #region EVENTS


        #endregion

    }
}
