<%@ Page Title="Cowan Bros | Construction" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="construction1.aspx.cs" Inherits="cowanbros.construction1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        
     
 
   

    <!-- TOP ROW -->
    <div class="container-fluid orange" >
  <h1>Case CX145Dsr</h1>
  <p>Perfect for working in Urban areas & Infrastructure</p>
  <p> Water-cooled, 4,cycle diesel, 4-cylinder in line, High pressure common rail system (electric control), Turbocharger with air cooled intercooler</p> <br>
         </div>





        <!--  Loads in the initial images -->
    <div class="container-fluid">
        <br>

    <div class="row">
        <div class="column">
            <img src="images/construction/1/20181026_164451.jpg"  onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/1/20181020_103309.jpg"  onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/1/20181020_103047.jpg"  onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/1/20181024_135952.jpg"  onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/construction/1/20181024_140016.jpg"  onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/1/20181020_103216.jpg"  onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/1/20181020_103352.jpg"  onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/1/20181031_162344.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
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
               <img src="images/construction/1/20181026_164451.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/construction/1/20181020_103309.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/construction/1/20181020_103047.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/construction/1/20181024_135952.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/construction/1/20181024_140016.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/construction/1/20181020_103216.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/construction/1/20181020_103352.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/construction/1/20181031_162344.jpg" class="rounded w-100">
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


    <a href="construction.aspx" class="btn btn-warning btn-block">Back</a>
    <br>

    <div class="container-fluid orange">
        <br>
    </div>


 
</asp:Content>
