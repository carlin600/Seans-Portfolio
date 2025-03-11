<%@ Page Title="Cowan Bros | Construction Home" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="construction.aspx.cs" Inherits="cowanbros.construction" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="stylesheet.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- ROWS -->

   

    <!-- TOP ROW -->
    <div class="container-fluid orange">
        <h1>CASE Construction</h1>
        <p>View our full range of Construction Machinery!</p>
        <p>Our range of CASE Construction Machinery ensure top quality & performance, even in the harshest environments!</p>
       

        <!-- FIRST ROW -->
    
        <div class="row white">
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="./images/construction/1/20181026_164451.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Case CX145Dsr</h4>
                        <p class="card-text">Perfect for working in Urban areas & Infrastructure</p>
                        <a href="construction1.aspx" class="btn btn-warning btn-block">View</a>
                    </div>
                </div>
            </div>
            
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="./images/construction/2/20181020_103523.jpg" alt="Card image" >
                    <div class="card-body">
                        <h4 class="card-title">Case Loader 721G</h4>
                        <p class="card-text">Can work in all environments easily without a struggle!</p>
                        <a href="construction2.aspx" class="btn btn-warning btn-block">View</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="./images/construction/3/20181026_170231.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Case CX80c</h4>
                        <p class="card-text">A Midi Excavator that can work in many environments!</p>
                        <a href="construction3.aspx" class="btn btn-warning btn-block">View</a>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="card w-450">
                    <img class="card-img-top w-100" src="./images/construction/4/20181024_143816.jpg" alt="Card image">
                    <div class="card-body">
                        <h4 class="card-title">Case CX26c</h4>
                        <p class="card-text">A Mini Digger with a lot of Hidden Power!</p>
                        <a href="construction4.aspx" class="btn btn-warning btn-block">View</a>
                    </div>
                </div>
            </div>
       </div>
    </div>

    <!-- END OF ROWS -->
    
    <div class="container-fluid orange">
        <br>
    </div>




</asp:Content>
