<%@ Page Title="Cowan Bros | Construction" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="construction4.aspx.cs" Inherits="cowanbros.construction4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <!-- TOP ROW -->
    <div class="container-fluid orange" >
  <h1>Case CX26c</h1>
  <p>A Mini Digger with a lot of Hidden Power!</p>
  <p>The CX26C provides excellent power and breakout force in a lightweight machine (5,520 pounds) – 
      ideal for landscapers and utility companies working in developed neighborhoods and trying to minimize yard damage. 
      Available with an optional heated cab and delivering a dig depth of 7’ 11”, the CX26C provides excellent application flexibility in a zero tail swing design.</p>
                 </div>






        <!--  Loads in the initial images -->
    <div class="container-fluid">
    <div class="row">
        <div class="column">
            <img src="images/construction/4/20181024_143816.jpg" onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/4/20181024_143829.jpg" onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/4/20181024_143848.jpg" onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/4/20181026_134828.jpg" onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/construction/4/20181024_143836.jpg" onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/4/20181024_143903.jpg" onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/4/20181024_144409.jpg" onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/4/20181020_104721.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
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
               <img src="images/construction/4/20181024_143816.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/construction/4/20181024_143829.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/construction/4/20181024_143848.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/construction/4/20181026_134828.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/construction/4/20181024_143836.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/construction/4/20181024_143903.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/construction/4/20181024_144409.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/construction/4/20181020_104721.jpg" class="rounded w-100">
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
