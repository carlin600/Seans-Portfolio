<%@ Page Title="Cowan Bros | Agriculture" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="agri1.aspx.cs" Inherits="cowanbros.agri1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    <!-- TOP ROW -->
    <div class="container-fluid red" >
  <h1>CASE Luxxum 110 </h1>
  <p>The Luxxum - Making Easy Work Of Hard Tasks!</p>
  <p>The Luxxum 110, Built with Cab Suspension, Powershuttle, Air Conditioning, A very powerful Hydraulic Push Out Pickup Hitch & top quality Michelin Tyres</p>
        <br>
         </div>





        <!--  Loads in the initial images -->
    <div class="container-fluid">
        <br>

    <div class="row">
        <div class="column">
            <img src="images/agriculture/1/20181109_125322.jpg"  onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/agriculture/1/20181109_125313.jpg"  onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/1/20181109_125327.jpg"  onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/1/20181109_125336.jpg"  onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/agriculture/1/20181109_125347.jpg"  onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/1/20181020_105755.jpg"  onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/agriculture/1/20181109_125454.jpg"  onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/agriculture/1/20181109_125517.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
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
               <img src="images/agriculture/1/20181109_125322.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/agriculture/1/20181109_125313.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/agriculture/1/20181109_125327.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/agriculture/1/20181109_125336.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/agriculture/1/20181109_125347.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/agriculture/1/20181020_105755.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/agriculture/1/20181109_125454.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/agriculture/1/20181109_125517.jpg" class="rounded w-100">
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
