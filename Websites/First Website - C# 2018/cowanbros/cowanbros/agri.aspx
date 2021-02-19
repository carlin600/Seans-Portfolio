<%@ Page Title="Cowan Bros | Agriculture Home" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agri.aspx.cs" Inherits="cowanbros.agri" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- ROWS -->

    <!-- TOP ROW -->
    <div class="container-fluid red">
        <h1>CASE Agriculture</h1>
        <p>Our range of CASE Agricultural Machinery ensure top quality & performance!</p>
        <p>Feel free to view our available machinery below.</p>

        <!-- FIRST ROW -->
        <div class="row white">
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100 " src="images/agriculture/1/20181109_125322.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">CASE Luxxum 110</h4>
                        <p class="card-text">The Luxxum - Making Easy Work Of Hard Tasks!</p>
                        <a href="agri1.aspx" class="btn btn-danger btn-block">View</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="images/agriculture/2/20181109_125118.jpg" >
                    <div class="card-body">
                        <h4 class="card-title">CASE Farmall 115c</h4>
                        <p class="card-text">The Farmall C - A Powerful Performer In The Field!</p>
                        <a href="agri2.aspx" class="btn btn-danger btn-block">View</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="images/agriculture/3/20181024_134121.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">CASE Maxxum 115</h4>
                        <p class="card-text">The MAXXUM - Designed To Be Efficient</p>
                        <a href="agri3.aspx" class="btn btn-danger btn-block">View</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="images/agriculture/4/20181026_100037.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">CASE Puma 165</h4>
                        <p class="card-text">The PUMA - Built For The Long & Hard Days </p>
                        <a href="agri4.aspx" class="btn btn-danger btn-block">View</a>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <!-- END OF ROWS -->



    <div class="container-fluid red">
        <br>
    </div>









</asp:Content>


