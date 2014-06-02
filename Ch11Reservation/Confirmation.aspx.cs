using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Confirmation : System.Web.UI.Page
{
    private Reservation reservation;

    protected void Page_Load(object sender, EventArgs e)
    {
        reservation = (Reservation)Session["Reservation"];
        this.DisplayReservation();
    }

    private void DisplayReservation()
    {
        lblArrivalDate.Text = reservation.ArrivalDate.ToShortDateString();
        lblDepartureDate.Text = reservation.DepartureDate.ToShortDateString();
        lblNoOfAdults.Text = reservation.NoOfAdults.ToString();
        lblNoOfChildren.Text = reservation.NoOfChildren.ToString();
        lblRoomType.Text = reservation.RoomType;
        lblBedType.Text = reservation.BedType;

        if (reservation.Smoking)
            lblSmoking.Text = "Yes";
        else
            lblSmoking.Text = "No";

        if (reservation.SpecialRequests == "")
            lblSpecialRequests.Text = "None";
        else
            lblSpecialRequests.Text = reservation.SpecialRequests;

        lblName.Text = reservation.Name;
        lblEmail.Text = reservation.Email;
    }

    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        lblMessage.Text = "Thank you for your request.<br />" +
                          "We will get back to you within 24 hours.";

        HttpCookie nameCookie = new HttpCookie("UserName", lblName.Text);
        nameCookie.Expires = DateTime.Now.AddMonths(6);
        Response.Cookies.Add(nameCookie);

        HttpCookie emailCookie = new HttpCookie("Email", lblEmail.Text);
        emailCookie.Expires = DateTime.Now.AddMonths(6);
        Response.Cookies.Add(emailCookie);
    }
}