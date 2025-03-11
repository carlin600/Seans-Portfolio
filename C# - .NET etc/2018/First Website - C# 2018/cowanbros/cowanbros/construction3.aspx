<%@ Page Title="Cowan Bros | Construction" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="construction3.aspx.cs" Inherits="cowanbros.construction3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
     <!-- TOP ROW -->
    <div class="container-fluid orange" >
  <h1>Case CX80c</h1>
  <p>A Midi Excavator that can work in many environments!</p>
  <p>The CASE CX80C mid-sized excavator brings the power and performance of a full-sized excavator in a smaller package for improved jobsite accessibility and efficiency. 
     The Tier 4 engine uses CEGR technology to maximize fuel efficiency in a simple yet powerful system. The CX80C offers 9% more hydraulic power than previous models 
      for greater digging power.</p>
                 </div>






        <!--  Loads in the initial images -->
    <div class="container-fluid">
    <div class="row">
        <div class="column">
            <img src="images/construction/3/20181026_170307.jpg" onclick="openModal();currentSlide(1)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/3/20181026_170231.jpg" onclick="openModal();currentSlide(2)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/3/20181026_170330.jpg" onclick="openModal();currentSlide(3)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/3/20181026_164414.jpg" onclick="openModal();currentSlide(4)" class="hover-shadow cursor rounded w-100">
        </div>
        </div>
    <br>
          <div class="row">
        <div class="column">
            <img src="images/construction/3/20181020_104249.jpg" onclick="openModal();currentSlide(5)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/3/20181020_104256.jpg" onclick="openModal();currentSlide(6)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
            <img src="images/construction/3/20181020_104124.jpg" onclick="openModal();currentSlide(7)" class="hover-shadow cursor rounded w-100">
        </div>
        <div class="column">
           <img src="images/construction/3/20181020_104158.jpg" onclick="openModal();currentSlide(8)" class="hover-shadow cursor rounded w-100">
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
               <img src="images/construction/3/20181026_170307.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">2 / 8</div>
                <img src="images/construction/3/20181026_170231.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">3 / 8</div>
                <img src="images/construction/3/20181026_170330.jpg" class="rounded w-100">
            </div>

            <div class="mySlides">
                <div class="numbertext">4 / 8</div>
                <img src="images/construction/3/20181026_164414.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">5 / 8</div>
                 <img src="images/construction/3/20181020_104249.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">6 / 8</div>
           <img src="images/construction/3/20181020_104256.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">7 / 8</div>
                  <img src="images/construction/3/20181020_104124.jpg" class="rounded w-100">
            </div>
             <div class="mySlides">
                <div class="numbertext">8 / 8</div>
                <img src="images/construction/3/20181020_104158.jpg" class="rounded w-100">
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
