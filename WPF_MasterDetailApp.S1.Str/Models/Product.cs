using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MasterDetailApp.Models
{
    public class Product
    {
        #region ENUMS



        #endregion

        #region FIELDS
        private string _albumName;
        private string _artistName;
        private string _genre;
        private string _format;
        private int _runtime;
        private double _price;
        private int _releaseYear;
        private string _imageName;

       











        #endregion

        #region PROPERTIES

        public string AlbumName
        {
            get { return _albumName; }
            set { _albumName = value; }
        }

        public string ArtistName
        {
            get { return _artistName; }
            set { _artistName = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }

        public int Runtime
        {
            get { return _runtime; }
            set { _runtime = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }

        public string ImageName
        {
            get { return _imageName; }
            set { _imageName = value; }
        }

        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS


        #endregion

        #region EVENTS



        #endregion
    }
}
