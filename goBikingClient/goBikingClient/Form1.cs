using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using Newtonsoft.Json.Linq;
using goBikingClient.goBikingServiceClient;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace goBikingClient
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> velib = new Dictionary<string, int>();
        Dictionary<string, List<Station>> listOfStations = new Dictionary<string, List<Station>>();
        Dictionary<string, Location> from = new Dictionary<string, Location>();
        Dictionary<string, Location> to = new Dictionary<string, Location>();
        Dictionary<string, double> nearests = new Dictionary<string, double>();
        Dictionary<string, Place> nearestSuggestion = new Dictionary<string, Place>();
        ServiceClientClient goBikingService = new ServiceClientClient();
        Dictionary<string, Review> reviews = new Dictionary<string, Review>();


        public Form1()
        {
            InitializeComponent();
            hideElement();
            prepareGGMap();
            prepareDataJCDecaux();
            prepareGuideTextBox();
        }

        private void contractListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableLabel.Text = "";
            stationListBox.Items.Clear();

            string contractName = contractListBox.SelectedItem.ToString();
            foreach(Station s in listOfStations[contractName])
            {
                stationListBox.Items.Add(s.Name);
            }
        }

        private void contractListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableLabel2.Text = "";
            stationListBox2.Items.Clear();

            string contractName = contractListBox2.SelectedItem.ToString();
            foreach (Station s in listOfStations[contractName])
            {
                stationListBox2.Items.Add(s.Name);
            }
        }

        private void contractListBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            availableLabel3.Text = "";
            stationListBox3.Items.Clear();

            string contractName = contractListBox3.SelectedItem.ToString();
            foreach (Station s in listOfStations[contractName])
            {
                stationListBox3.Items.Add(s.Name);
            }
        }

        private void contractListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // availableLabel4.Text = "";
            stationListBox4.Items.Clear();

            string contractName = contractListBox4.SelectedItem.ToString();
            foreach (Station s in listOfStations[contractName])
            {
                stationListBox4.Items.Add(s.Name);
            }
        }

        private void getInformationButton_Click(object sender, EventArgs e)
        {
            availableLabel.Text = velib[stationListBox.SelectedItem.ToString()].ToString();
            availableLabel2.Text = velib[stationListBox2.SelectedItem.ToString()].ToString();
            lat1Label.Text = from[stationListBox.SelectedItem.ToString()].Latitude.ToString();
            lng1Label.Text = to[stationListBox.SelectedItem.ToString()].Longitude.ToString();
            lat2Label.Text = from[stationListBox2.SelectedItem.ToString()].Latitude.ToString();
            lng2Label.Text = to[stationListBox2.SelectedItem.ToString()].Longitude.ToString();
           


            //getRoute(lat1Label.Text, lng1Label.Text, lat2Label.Text, lng2Label.Text);
            drawPolyLine(getRoute(lat1Label.Text, lng1Label.Text, lat2Label.Text, lng2Label.Text), gmap);
        }

        private List<Location> getRoute(string lat1, string lng1, string lat2, string lng2)
        {
            //GG map web service via WS client
            List<Location> listOfPoints = new List<Location>();
            listOfPoints = goBikingService.getRoute(lat1, lng1, lat2, lng2).ToList<Location>();
          
            /*
            foreach (Location location in listOfPoints)
            {
                Console.WriteLine(location.Latitude + " - " + location.Longitude);
            }
            */
            return listOfPoints;
        }

        private void prepareDataJCDecaux()
        {
            //JCDecaux web service via WS client
            stationListBox.Items.Clear();
            listOfStations.Clear();
            velib.Clear();
            from.Clear();
            Contract[] contracts = new Contract[] { };
            contracts = goBikingService.loadContracts();
            foreach (Contract contract in contracts)
            {
                contractListBox.Items.Add(contract.Name);
                contractListBox2.Items.Add(contract.Name);
                contractListBox3.Items.Add(contract.Name);
                contractListBox4.Items.Add(contract.Name);
                //ServiceClientClient goBikingService = new ServiceClientClient();
                listOfStations.Add(contract.Name, goBikingService.loadStations(contract.Name).ToList<Station>());
                foreach (Station station in listOfStations[contract.Name])
                {

                    velib[station.Name] = station.Available_bikes;
                    from[station.Name] = new Location()
                    {
                        Latitude = Convert.ToDouble(station.Lat),
                        Longitude = Convert.ToDouble(station.Lng)
                    };
                    to[station.Name] = new Location()
                    {
                        Latitude = Convert.ToDouble(station.Lat),
                        Longitude = Convert.ToDouble(station.Lng)
                    };
                }
            }
        }

        private void prepareGGMap()
        {
            //GMAP
            gmap.DragButton = MouseButtons.Left;
            gmap2.DragButton = MouseButtons.Left;
            gmap3.DragButton = MouseButtons.Left;
            gmap4.DragButton = MouseButtons.Left;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap2.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap3.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            gmap4.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            //GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.ShowCenter = false;
            gmap.Position = new GMap.NET.PointLatLng(43, -84);
            gmap.MinZoom = 5;
            gmap.MaxZoom = 100;
            gmap.Zoom = 10;
            gmap2.ShowCenter = false;
            gmap2.Position = new GMap.NET.PointLatLng(43, -84);
            gmap2.MinZoom = 5;
            gmap2.MaxZoom = 100;
            gmap2.Zoom = 10;
            gmap3.ShowCenter = false;
            gmap3.Position = new GMap.NET.PointLatLng(43, -84);
            gmap3.MinZoom = 5;
            gmap3.MaxZoom = 100;
            gmap3.Zoom = 10;
            gmap4.ShowCenter = false;
            gmap4.Position = new GMap.NET.PointLatLng(43, -84);
            gmap4.MinZoom = 5;
            gmap4.MaxZoom = 100;
            gmap4.Zoom = 10;
        }

        private void drawPolyLine(List<Location> points, GMapControl gmap)
        {
            gmap.Overlays.Clear();
            PointLatLng start = new PointLatLng(points[0].Latitude, points[0].Longitude);
            PointLatLng end = new PointLatLng(points[points.Count - 1].Latitude, points[points.Count - 1].Longitude);
            gmap.Position = start;

            //MARKERS
            GMapMarker start_marker = new GMarkerGoogle(start, GMarkerGoogleType.red_dot);
            GMapMarker end_marker = new GMarkerGoogle(end, GMarkerGoogleType.blue_dot);
            start_marker.ToolTipText = "Start point\n"+"Latitude: "+start.Lat+"\nLongitude: "+start.Lng;
            end_marker.ToolTipText = "End point\n" + "Latitude: " + end.Lat + "\nLongitude: " + end.Lng;
            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(start_marker);
            markers.Markers.Add(end_marker);

            gmap.Overlays.Add(markers);


            //ROUTES
            List<PointLatLng> waypoints = new List<PointLatLng>();
            foreach (Location point in points)
            {
                waypoints.Add(new PointLatLng(point.Latitude, point.Longitude));
            }

            GMapRoute r = new GMapRoute("My Route")
            {
                Stroke = new Pen(Color.Red, 5)
            };
            GMapOverlay routes = new GMapOverlay("routes");
            routes.Routes.Add(r);
            gmap.Overlays.Add(routes);

            foreach (PointLatLng point in waypoints)
            {
                r.Points.Add(point);
            }

            gmap.UpdateRouteLocalPosition(r);
        }

        private void getInformationButton2_Click(object sender, EventArgs e)
        {
            drawPolyLine(getRoute(latFromTextBox.Text, lngFromTextBox.Text, latToTextBox.Text, lngToTextBox.Text), gmap2);
        }

        private void getInformationButton3_Click(object sender, EventArgs e)
        {
            nearestListBox.Items.Clear();
            nearests.Clear();
            availableLabel3.Text = velib[stationListBox3.SelectedItem.ToString()].ToString();
            lat3Label.Text = from[stationListBox3.SelectedItem.ToString()].Latitude.ToString();
            lng3Label.Text = to[stationListBox3.SelectedItem.ToString()].Longitude.ToString();

            String lat = lat3Label.Text;
            String lng = lng3Label.Text;
            string contract_station_name = contractListBox3.SelectedItem.ToString();

            Dictionary<Station, double> local_nearest = new Dictionary<Station, double>();
            local_nearest = goBikingService.getNearestStations(lat, lng, contract_station_name);

            foreach(Station s in local_nearest.Keys)
            {
                nearests[s.Name] = local_nearest[s];
                nearestListBox.Items.Add(s.Name);
                // + " --- " + Math.Round(nearests[s], 4).ToString() + " km"
            }

        }

        private void getRouteButton_Click(object sender, EventArgs e)
        {
            lat3Label.Text = from[stationListBox3.SelectedItem.ToString()].Latitude.ToString();
            lng3Label.Text = from[stationListBox3.SelectedItem.ToString()].Longitude.ToString();
            lat4Label.Text = to[nearestListBox.SelectedItem.ToString()].Latitude.ToString();
            lng4Label.Text = to[nearestListBox.SelectedItem.ToString()].Longitude.ToString();

            availableLabel4.Text = velib[nearestListBox.SelectedItem.ToString()].ToString();
            distanceLabel.Text = nearests[nearestListBox.SelectedItem.ToString()].ToString();

            //getRoute(lat1Label.Text, lng1Label.Text, lat2Label.Text, lng2Label.Text);
            drawPolyLine(getRoute(lat3Label.Text, lng3Label.Text, lat4Label.Text, lng4Label.Text), gmap3);

        }
        private void prepareGuideTextBox()
        {
            guideTextBox.Text = "The application used to calculate the route between two points." + "\n" +
                "You can either manually enter the coordinates of these two points in the Default tab, or retrieve information from JCDecaux stations and calculate the route between two stations chosen in the JCDecaux tab.";
        }

        private void hideElement()
        {
            nearestListBox.Visible = false;
            placeNameLabel.Visible = false;
            placeAddressLabel.Visible = false;
            placeNameFixedLabel.Visible = false;
            placeAddressFixedLabel.Visible = false;
            commentAuthorListBox.Visible = false;
            commentTextBox.Visible = false;
            getInformationBtn4.Visible = false;
            getRouteBtn4.Visible = false;
        }
        private void showElement()
        {
            nearestListBox.Visible = true;
            placeNameLabel.Visible = true;
            placeAddressLabel.Visible = true;
            placeNameFixedLabel.Visible = true;
            placeAddressFixedLabel.Visible = true;
            commentAuthorListBox.Visible = true;
            commentTextBox.Visible = true;
            getInformationBtn4.Visible = true;
            getRouteBtn4.Visible = true;
            nearestPlaceListBox.BorderStyle = BorderStyle.Fixed3D;
        }
        private void getNearestPlaceBtn_Click(object sender, EventArgs e)
        {
            nearestPlaceListBox.Items.Clear();
            //nearestSuggestion.Clear();

            string lat = from[stationListBox4.SelectedItem.ToString()].Latitude.ToString();
            string lng = from[stationListBox4.SelectedItem.ToString()].Longitude.ToString();
            string radius = "0";
            showElement();
            if(radiusTextBox.Text == "")
            {
                radius = "1500";
            }else
            {
                radius = radiusTextBox.Text;
            }
            
            List<Place> nearestPlace = goBikingService.nearBySearch(lat, lng, radius).ToList();

            foreach (Place p in nearestPlace)
            {
                nearestPlaceListBox.Items.Add(p.Name);
                if (!nearestSuggestion.ContainsKey(p.Name)) {
                    nearestSuggestion.Add(p.Name, p);
                }
            }
        }

        private void getInformationBtn4_Click(object sender, EventArgs e)
        {
            commentAuthorListBox.Items.Clear();
            commentTextBox.Clear();
            reviews.Clear();

            Place placeSelected = nearestSuggestion[nearestPlaceListBox.SelectedItem.ToString()];
            placeNameLabel.Text = placeSelected.Name.ToString();
            placeAddressLabel.Text = placeSelected.Address.ToString();

            List<Review> placeReviews = loadReview(placeSelected.Name);

            foreach (Review r in placeReviews)
            {
                commentAuthorListBox.Items.Add(r.Author);
                reviews.Add(r.Author, r);
            }
        }


        private List<Review> loadReview(string placeName)
        {
            return nearestSuggestion[placeName].Reviews.ToList();
        }

        private void loadComment(object sender, EventArgs e) {
            string res = "";
            commentTextBox.Clear();
            string authorName = commentAuthorListBox.SelectedItem.ToString();
            string rating = reviews[authorName].Rating.ToString();
            string time = reviews[authorName].Time_description.ToString();
            string content = reviews[authorName].Content.ToString();
            res = "Time: "+ time + Environment.NewLine + "Rating: " + rating  + Environment.NewLine + "Comment: " + content;
            commentTextBox.Text = res;

        }

        private void getRouteBtn4_Click(object sender, EventArgs e)
        {
            string latFrom = from[stationListBox4.SelectedItem.ToString()].Latitude.ToString();
            string lngFrom = from[stationListBox4.SelectedItem.ToString()].Longitude.ToString();
            string latTo = nearestSuggestion[nearestPlaceListBox.SelectedItem.ToString()].Location.Latitude.ToString();
            string lngTo = nearestSuggestion[nearestPlaceListBox.SelectedItem.ToString()].Location.Longitude.ToString();




            //getRoute(lat1Label.Text, lng1Label.Text, lat2Label.Text, lng2Label.Text);
            drawPolyLine(getRoute(latFrom, lngFrom, latTo, lngTo), gmap4);
        }
    }
}
