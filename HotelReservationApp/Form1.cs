using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HotelReservationApp
{
    public partial class Form1 : Form
    {
        String title,fname,lname,email,phone,city,state,country,postalcode,roomtype,noofguests, totalnights;
        DateTime arrivaldate, departuredate;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Show time on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                clockLabel.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// when no. of nights changed departure date automatically changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkin_ValueChanged(object sender, EventArgs e)
        {
            int nights = Convert.ToInt32(noOfNights.Value); //no of nights selected
            DateTime newDate = checkin.Value.AddDays(nights); // date after adding nights
            checkout.Value = newDate;
        }

        private void noOfNights_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int nights = Convert.ToInt32(noOfNights.Value); //no of nights selected
                DateTime newDate = checkin.Value.AddDays(nights); // date after adding nights
                checkout.Value = newDate;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }
        /// <summary>
        /// Form close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EmailTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                EmailTextBox.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// when gust number get changed room type automatically changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuestNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                noofguests = GuestNumericUpDown.Value.ToString();
                int guest_count = Convert.ToInt32(noofguests);
                if (guest_count > 4)
                {
                    roomtypeTextBox.Text = "Family Suite";
                    roomtype = "Family Suite";
                }
                else if (guest_count <= 4 && guest_count > 1)
                {
                    roomtypeTextBox.Text = "2 Queen Beds";
                    roomtype = "2 Queen Beds";
                }
                else if (guest_count == 1)
                {
                    roomtypeTextBox.Text = "California King Bed";
                    roomtype = "California King Bed";
                }
                else
                {
                    roomtypeTextBox.Enabled = false;
                    roomtypeTextBox.Text = "0";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

       /// <summary>
       /// when click event perform on textbox default string removed automatically
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void titleTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                titleTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void FirstNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                FirstNameTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void LastNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                LastNameTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cityTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                cityTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void stateTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                stateTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void countaryTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                countaryTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void postalcodeTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                postalcodeTextBox.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        /// <summary>
        /// clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            try
            {
                titleTextBox.Text = "Title";
                FirstNameTextBox.Text = "Enter first name";
                LastNameTextBox.Text = "Enter last name";
                EmailTextBox.Text = "Ex: myname@example.com";
                PhoneTextBox.Text = "";
                cityTextBox.Text = "City";
                stateTextBox.Text = "State";
                countaryTextBox.Text = "Countary";
                postalcodeTextBox.Text = "Postal Code";
                noOfNights.Value = 0;
                GuestNumericUpDown.Value = 0;
                roomtypeTextBox.Text = "";
                checkin.Value = DateTime.Now;
                checkout.Value = DateTime.Now;
                descriptionLabel.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// submit summary description
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int check = 1;
                descriptionLabel.Text = string.Empty;

                title = titleTextBox.Text;
                fname = FirstNameTextBox.Text;
                lname = LastNameTextBox.Text;
                email = EmailTextBox.Text;
                phone = PhoneTextBox.Text;
                city = cityTextBox.Text;
                state = stateTextBox.Text;
                country = countaryTextBox.Text;
                postalcode = postalcodeTextBox.Text;
                totalnights = noOfNights.Value.ToString();
                noofguests = GuestNumericUpDown.Value.ToString();
                arrivaldate = checkin.Value;
                departuredate = checkout.Value;

                //validation for title
                if (title == String.Empty || title == "Title")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Title cannot be empty");
                    titleTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(title, @"^[a-zA-Z]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Title contains only alphabets");
                    titleTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    titleTextBox.BackColor = Color.White;

                }

                //validation for first name
                if (fname == String.Empty || fname == "Enter first name")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n First name cannot be empty");
                    FirstNameTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(fname, @"^[a-zA-Z]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n First name contains only alphabets");
                    FirstNameTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    FirstNameTextBox.BackColor = Color.White;

                }

                //validation for last name
                if (lname == String.Empty || lname == "Enter last name")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Last name cannot be empty");
                    LastNameTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(lname, @"^[a-zA-Z]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Last name contains only alphabets");
                    LastNameTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    LastNameTextBox.BackColor = Color.White;
                }

                //validation for email
                if (email == String.Empty || email == "Ex: myname@example.com")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Email cannot be empty");
                    EmailTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Email should be valid");
                    EmailTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    EmailTextBox.BackColor = Color.White;
                }
                // validation for phone number
                if (phone == string.Empty)
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Phone Number cannot be empty");
                    PhoneTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (Regex.IsMatch(phone, @"^[a-zA-Z]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Phone no. only accept numbers");
                    PhoneTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (phone.Length != 10)
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Phone no. must have 10 digit");
                    PhoneTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    PhoneTextBox.BackColor = Color.White;
                }

                //validation for city
                if (city == String.Empty || city == "City")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n City cannot be empty");
                    cityTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(city, @"^[a-zA-Z ]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n City contains only alphabets");
                    cityTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    cityTextBox.BackColor = Color.White;
                }

                //validation for state
                if (state == String.Empty || state == "State")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n State cannot be empty");
                    stateTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(state, @"^[a-zA-Z ]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n State contains only alphabets");
                    stateTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    stateTextBox.BackColor = Color.White;
                }
                //validation for country

                if (country == String.Empty || country == "Country")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Country cannot be empty");
                    countaryTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else if (!Regex.IsMatch(country, @"^[a-zA-Z ]+$"))
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Country contains only alphabets");
                    countaryTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    countaryTextBox.BackColor = Color.White;
                }
                
                //validation for postal code
                if (postalcode == string.Empty || postalcode == "Postal Code")
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Postal code cannot be empty");
                    postalcodeTextBox.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    postalcodeTextBox.BackColor = Color.White;
                }

                //validation for guest number
                if (GuestNumericUpDown.Value == 0)
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Seclect the guest numbers");
                    GuestNumericUpDown.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    GuestNumericUpDown.BackColor = Color.White;
                }
                //validation of for number of nights
                if (noOfNights.Value == 0)
                {
                    descriptionLabel.Text = string.Concat(descriptionLabel.Text, "\n Select number of nights");
                    noOfNights.BackColor = Color.Red;
                    check = 0;
                }
                else
                {
                    noOfNights.BackColor = Color.White;
                }

                //show summary description on label
                if (check == 1)
                {
                    descriptionLabel.Text = "Name: " + title + " " + fname + " " + lname +
                                       "\n Email: " + email +
                                       "\n Phone No.: " + phone + " " + " Address: " + city + " " + state + " " + country + " " + postalcode +
                                       "\n Total Guest: " + noofguests + " Total nights: " + totalnights +
                                       "\nRoom Type: " + roomtype +
                                       "\n Arrival Date: " + arrivaldate + " " + "Departure Date: " + departuredate;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

    }
}
