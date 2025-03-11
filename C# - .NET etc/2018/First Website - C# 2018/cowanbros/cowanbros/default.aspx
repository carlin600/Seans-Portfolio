<%@ Page Title="Cowan Bros | Home " Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="cowanbros.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="demo" class="carousel slide" data-ride="carousel">

        <!-- Indicators -->
        <ul class="carousel-indicators">
            <li data-target="#demo" data-slide-to="0" class="active"></li>
            <li data-target="#demo" data-slide-to="1"></li>
            <li data-target="#demo" data-slide-to="2"></li>
        </ul>

        <!-- The slideshow -->
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="images/cowans/20181020_111810.jpg">
            </div>
            <div class="carousel-item">
                <img src="images/cowans/20181020_111657.jpg">
            </div>
            <div class="carousel-item">
                <img src="images/cowans/20181024_140045.jpg">
            </div>
        </div>

        <!-- Left and right controls -->
        <a class="carousel-control-prev" href="#demo" data-slide="prev">
            <span class="carousel-control-prev-icon"></span>
        </a>
        <a class="carousel-control-next" href="#demo" data-slide="next">
            <span class="carousel-control-next-icon"></span>
        </a>
    </div>


    <!--AGRICULTURE TAB-->
    <div class="container-fluid red">
        <br>
    </div>
    <div class="container-fluid white">
        <h1 class="display-4">Our Agriculture Range </h1>
        <div class="row">
            <div class="col-sm">
                <p>At Cowan Bros, we have a full range of CASE Agriculture machinery that are not only award winnning machines, but machines that are built to last!</p>
                
                <blockquote class="blockquote">
                    <p>machines that <b>WORK WITH YOU </b></p>
                    <footer class="blockquote-footer">CASE Agriculture</footer>
                </blockquote>

                <a class="navbar-brand" href="agri.aspx">
                    <img src="images/cowans/CAL.jpg" class="rounded brandlogo " alt="logo">
                </a>
            </div>
           
           
            <div class="col-sm ">

                <div id="agriculture" class="carousel slide w-100" data-ride="carousel">


                    <!-- agriculture slideshow -->
                    <div class="carousel-inner rounded">
                        <div class="carousel-item active rounded">
                            <img class="rounded w-75" src="images/cowans/CAL.jpg">
                        </div>

                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/agriculture/1/20181109_125322.jpg">
                            <div class="carousel-caption w-75">
                                <h3>CASE Luxxum 110</h3>
                            </div>

                        </div>
                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/agriculture/2/20181109_125118.jpg">
                            <div class="carousel-caption w-75">
                                <h3>CASE Farmall 115c</h3>
                            </div>
                        </div>
                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/agriculture/3/20181024_134121.jpg">
                            <div class="carousel-caption w-75">
                                <h3>CASE Maxxum 115</h3>
                            </div>

                        </div>
                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/agriculture/4/20181026_100037.jpg">
                            <div class="carousel-caption w-75">
                                <h3>CASE Puma 165</h3>
                            </div>

                        </div>
                    </div>
                </div>
                <br>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <br>
    </div>

    <!--CONSTRUCTION TAB-->

    <div class="container-fluid">
        <br>
    </div>
    <div class="container-fluid white">
        <h1 class="display-4">Our Construction Range </h1>
        <div class="row">
            <div class="col-sm">
                <p>At Cowan Bros, we have a full range of CASE Consturction machinery, no job too big or small, we have a full range of small diggers, to big excavators & loaders! </p>
                <blockquote class="blockquote">
                    <p>your machine for <b>PRODUCTIFITY AND PERFORMANCE </b></p>
                    <footer class="blockquote-footer">CASE Construction</footer>
                </blockquote>
                
                <a class="navbar-brand" href="construction.aspx">
                    <img src="images/cowans/CCL.png" class="rounded brandlogo" alt="logo">
                </a>
            </div>
            
            <div class="col-sm ">

                <div id="construction" class="carousel slide w-100" data-ride="carousel">


                    <!-- construction slideshow -->
                    <div class="carousel-inner rounded">
                        <div class="carousel-item active rounded">
                            <img class="rounded w-75" src="images/cowans/CCL.png">
                        </div>

                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/construction/1/20181026_164451.jpg">
                            <div class="carousel-caption w-75">
                                <h3>Case CX145Dsr</h3>
                            </div>

                        </div>
                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/construction/2/20181020_103523.jpg">
                            <div class="carousel-caption w-75">
                                <h3>Case 721G</h3>
                            </div>
                        </div>
                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/construction/3/20181026_170231.jpg">
                            <div class="carousel-caption w-75">
                                <h3>Case CX80c</h3>
                            </div>

                        </div>
                        <div class="carousel-item rounded">
                            <img class="rounded w-75" src="images/construction/4/20181024_143816.jpg">
                            <div class="carousel-caption w-75">
                                <h3>Case CX26c</h3>
                            </div>
                        </div>
                    </div>
                </div>
                <br>
            </div>
        </div>
        
    </div>
    <div class="container-fluid orange"><br></div>







</asp:Content>
