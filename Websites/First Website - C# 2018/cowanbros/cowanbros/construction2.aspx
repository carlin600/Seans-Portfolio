<%@ Page Title="Cowan Bros | Construction" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="construction2.aspx.cs" Inherits="cowanbros.construction2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <!-- TOP ROW -->
    <div class="container-fluid orange" >
  <h1>Case 721G</h1>
  <p>Can work in all environments easily without a struggle!</p>
  <p>The 721G offers 33,000 lbs of breakout force, as well as a 5-speed transmission with lock-up torque converter that provides faster acceleration and travel speeds up to 25 mph (40 kph).</p>
                 </div>






        <!--  Loads in the initial images -->
    <div class="container-fluid">
    <div class="row">
        <div class="column">
            <img src="images/construction/2/20181102_143121.jpg" onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/2/20181102_143149.jpg" onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/2/20181102_143207.jpg" onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/2/20181102_143227.jpg" onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/construction/2/20181020_103654.jpg" onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/2/20181031_170558.jpg" onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/2/20181031_170500.jpg" onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/2/20181031_170509.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
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
               <img src="images/construction/2/20181102_143121.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/construction/2/20181102_143149.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/construction/2/20181102_143207.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/construction/2/20181102_143227.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/construction/2/20181020_103654.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/construction/2/20181031_170558.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/construction/2/20181031_170500.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/construction/2/20181031_170509.jpg" class="rounded w-100">
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
    <br >

    <div class="container-fluid orange">
        <br>
    </div>




</asp:Content>
