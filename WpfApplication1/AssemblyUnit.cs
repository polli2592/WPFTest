using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WpfApplication1
{
    public class AssemblyUnit
    {
        public string Description { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public Part Partunit { get; set; }

        private bool? _isChecked;

        public bool? IsChecked { get; set; }


        public AssemblyUnit(string _description,string _code,string _name,string _position, Part _partunit)
        {
            Description = _description;
            Code = _code;
            Name = _name;
            Position = _position;
            Partunit = _partunit;

        }

       /* void SetIsChecked(bool? value, bool updateChildren, bool updateParent)
        {
            if (value == _isChecked)
                return;

            _isChecked = value;

            if (updateChildren && _isChecked.HasValue)
                this.Children.ForEach(c => c.SetIsChecked(_isChecked, true, false));

            if (updateParent && _parent != null)
                _parent.VerifyCheckState();

            this.OnPropertyChanged("IsChecked");
        }*/

   /*     void VerifyCheckState()
        {
            bool? state = null;
            for (int i = 0; i < this.Children.Count; ++i)
            {
                bool? current = this.Children[i].IsChecked;
                if (i == 0)
                {
                    state = current;
                }
                else if (state != current)
                {
                    state = null;
                    break;
                }
            }
            this.SetIsChecked(state, false, true);
        }*/


    }

    public enum Part
    {
        Detail = 4,
        AssemblyUnit=1,
        Kompleks=2,
        VariableDate = 3

    }
    class BindingProxy : Freezable
    {
        //Override of Freezable
        protected override Freezable CreateInstanceCore()
        {
            return new BindingProxy();
        }
        public object Data
        {
            get { return (object)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }
        public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(object), typeof(BindingProxy), new UIPropertyMetadata(null));
    }


    public class Column : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        protected internal void OnPropertyChanged(string propertyname)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
        }

        public DataGridLength Width
        {
            get { return m_width; }
            set { m_width = value; OnPropertyChanged("Width"); }
        }
        DataGridLength m_width;
    }


    public class PartSp
    {
        public Part PartSpec { get; set; }

        public List<AssemblyUnit> Units { get; set; }

        public List<Part> ChildPart { get; set; }

        public bool? IsChecked { get; set; }

    }
}
