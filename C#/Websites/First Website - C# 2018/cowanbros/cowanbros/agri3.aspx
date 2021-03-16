<%@ Page Title="Cowan Bros | Agriculture" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agri3.aspx.cs" Inherits="cowanbros.agri3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
        <!-- TOP ROW -->
    <div class="container-fluid red" >
  <h1>CASE Maxxum 115 </h1>
  <p>The MAXXUM - Designed To Be Efficient</p>
  <p>Air Suspension front and back, air suspended seat. Eight Speed Powershaft and much more. Brand new Michelin Tyres.</p> <br>
         </div>





        <!--  Loads in the initial images -->
    <div class="container-fluid">
        <br>

    <div class="row">
        <div class="column">
            <img src="images/agriculture/3/20181024_134121.jpg"  onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/agriculture/3/20181024_134140.jpg"  onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/3/20181024_140035.jpg"  onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/3/20181020_110131.jpg"  onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/agriculture/3/20181020_110258.jpg"  onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/3/20181020_110231.jpg"  onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/3/20181020_110235.jpg"  onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/agriculture/3/20181024_173841.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
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
               <img src="images/agriculture/3/20181024_134121.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/agriculture/3/20181024_134140.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/agriculture/3/20181024_140035.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/agriculture/3/20181020_110131.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/agriculture/3/20181020_110258.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/agriculture/3/20181020_110231.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/agriculture/3/20181020_110235.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/agriculture/3/20181024_173841.jpg" class="rounded w-100">
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
