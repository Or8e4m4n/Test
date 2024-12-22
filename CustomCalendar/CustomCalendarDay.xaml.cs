using System.Windows;
using System.Windows.Controls;

namespace Test
{
    /// <summary></summary>
    public partial class CustomCalendarDay : UserControl
    {
        #region Public Static Readonly Members

        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register(
                nameof(DateProperty),
                typeof(DateTime),
                typeof(CustomCalendarDay),
                new PropertyMetadata(DateTime.Today));

        #endregion

        #region Public Properties

        public DateTime Date
        {
            get => (DateTime)GetValue(DateProperty);
            set => SetValue(DateProperty, value);
        }

        #endregion

        #region Public Constructors

        /// <summary>Default constructor.</summary>
        public CustomCalendarDay()
        {
            InitializeComponent();
        }

        #endregion
    }
}