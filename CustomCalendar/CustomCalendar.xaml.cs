using System.Windows;
using System.Windows.Controls;

namespace Test
{
    /// <summary></summary>
    public partial class CustomCalendar : UserControl
    {
        #region Public Static Readonly Members

        public static readonly DependencyProperty DatesProperty =
            DependencyProperty.Register(
                nameof(Dates),
                typeof(List<DateTime>),
                typeof(CustomCalendar),
                new PropertyMetadata(null, DatesChangedCallback));

        #endregion

        #region Public Properties

        public List<DateTime> Dates
        {
            get => GetValue(DatesProperty) as List<DateTime>;
            set => SetValue(DatesProperty, value);
        }

        #endregion

        #region Public Constructors

        /// <summary>Default constructor.</summary>
        public CustomCalendar()
        {
            InitializeComponent();

            Update();
        }

        #endregion

        #region Private Static Methods

        /// <summary></summary>
        private void Update()
        {
            var firstMonthDate = new DateTime(2024, 12, 1);
            var lastMonthDate = new DateTime(2024, 12, DateTime.DaysInMonth(2024, 12));

            var day = firstMonthDate.DayOfWeek;

            var firstDate = firstMonthDate;

            switch (day)
            {
                case DayOfWeek.Sunday:

                    firstDate = firstDate.AddDays(-6);

                    break;
            }

            var lastDate = firstDate.AddDays(28);

            if (lastDate < lastMonthDate)
            {
                lastDate = lastDate.AddDays(7);
            }

            Dates = [];

            // Loops through all days.
            for (var date = firstDate; date <= lastDate; date = date.AddDays(1))
            {
                Dates.Add(date);
            }
        }

        private static void DatesChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        #endregion
    }
}
