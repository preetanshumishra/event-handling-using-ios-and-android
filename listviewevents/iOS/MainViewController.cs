using System;
using Foundation;
using UIKit;

namespace listviewevents.iOS
{
    public class MainViewController : UIViewController
    {
        UITableView mainTableView;
        UITextView textView;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            mainTableView = new UITableView();
            mainTableView.TranslatesAutoresizingMaskIntoConstraints = false;
            mainTableView.Source = new MainTableViewSource(mainTableView);

            textView = new UITextView();
            textView.TranslatesAutoresizingMaskIntoConstraints = false;
            textView.Text = "Hello!!!";

            View.AddSubview(mainTableView);

            var leftCt = NSLayoutConstraint.Create(mainTableView, NSLayoutAttribute.Left, NSLayoutRelation.GreaterThanOrEqual, View, NSLayoutAttribute.Left, 1, 50);
            var rightCt = NSLayoutConstraint.Create(mainTableView, NSLayoutAttribute.Right, NSLayoutRelation.LessThanOrEqual, View, NSLayoutAttribute.Right, 1, 50);
            var topCt = NSLayoutConstraint.Create(mainTableView, NSLayoutAttribute.Top, NSLayoutRelation.GreaterThanOrEqual, View, NSLayoutAttribute.Top, 1, 50);
            var bottomCt = NSLayoutConstraint.Create(mainTableView, NSLayoutAttribute.Bottom, NSLayoutRelation.LessThanOrEqual, View, NSLayoutAttribute.Bottom, 1, 50);

            var contraints = new NSLayoutConstraint[] { leftCt, rightCt, topCt, bottomCt };

            View.AddConstraints(contraints);
        }
    }

    public class MainTableViewSource : UITableViewSource
    {
        string[] dataSource = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public MainTableViewSource(UITableView tableView)
        {
            tableView.RegisterClassForCellReuse(typeof(MainTableViewCell), MainTableViewCell.CellIdentifier);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            return tableView.DequeueReusableCell(MainTableViewCell.CellIdentifier, indexPath);
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return dataSource.Length;
        }
    }

    public class MainTableViewCell : UITableViewCell
    {
        public static string CellIdentifier = "MainTableViewCell";

        public MainTableViewCell()
        {

        }
    }
}