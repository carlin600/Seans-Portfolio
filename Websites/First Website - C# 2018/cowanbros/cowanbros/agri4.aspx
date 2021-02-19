<%@ Page Title="Cowan Bros | Agriculture" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agri4.aspx.cs" Inherits="cowanbros.agri4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

           <!-- TOP ROW -->
    <div class="container-fluid red" >
  <h1>CASE Puma 165 </h1>
  <p>The PUMA - Built For The Long & Hard Days</p>
  <p>Built in Engine Exhaust Brake. 4 Rear Mechanical Remotes. Front linkage operate through Mid-Mounts. Comes with High Intensity Work Light Pack - 14 LED Lights. Air Brakes also installed.</p><br>
         </div>





        <!--  Loads in the initial images -->
    <div class="container-fluid">
        <br>

    <div class="row">
        <div class="column">
            <img src="images/agriculture/4/20181026_100033.jpg"  onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/agriculture/4/20181026_100046.jpg"  onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/4/20181026_100105.jpg"  onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/4/20181020_110452.jpg"  onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/agriculture/4/20181024_173841.jpg"  onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/4/20181020_110537.jpg"  onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/4/20181020_110552.jpg"  onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/agriculture/4/20181020_110556.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
        </div>
    </div>
        </div>
    <br />



    <!-- Loads the larger version of each image -->
    <div id="myModal" class="modal">
        <span class="close cursor" onclick="closeModal()">&times;</span>
        <div class="modal-content">

            <div class="mySlides">
                <div class="numbertext">1 / 8</div>
               <img src="images/agriculture/4/20181026_100033.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/agriculture/4/20181026_100046.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/agriculture/4/20181026_100105.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/agriculture/4/20181020_110452.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/agriculture/4/20181024_173841.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/agriculture/4/20181020_110537.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/agriculture/4/20181020_110552.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/agriculture/4/20181020_110556.jpg" class="rounded w-100">
            </div>

            <a class="prev" onclick="plusSlides(-1)">&#10094;</a>
            <a class="next" onclick="plusSlides(1)">&#10095;</a>

            <div class="caption-container">
                <p id="caption"></p>
            </div>

        </div>
    </div>

    <!-- This script file is necessary to make the lightboxes work -->
    <script src="LightboxJavaScript.js"></script>


    <a href="agri.aspx" class="btn btn-danger btn-block">Back</a>
    <br>

    <div class="container-fluid red">
        <br>
    </div>
    
    
    



</asp:Content>
