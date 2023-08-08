<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="prac4_1.Home" MasterPageFile="~/MasterPage.master"  %>




<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
   
     <style>
        /* Adding styles to make it catchy */
        
            p {
                font-size: 24px;
                color: #666666;
                margin-bottom: 40px;
            }

        .cta-button {
            display: inline-block;
            padding: 10px 20px;
            background-color: #ff6600;
            color: #ffffff;
            font-size: 18px;
            border-radius: 5px;
            text-decoration: none;
            transition: background-color 0.3s ease;
             text-align: center;
             animation: blink-animation 1s infinite;
         }

        .cta-button:hover {
            background-color: #ff5500;
        }

        @keyframes blink-animation {
        0% { opacity: 0; }
        50% { opacity: 1; }
        100% { opacity: 0; }
    }
        .guidelines {
            font-size: 18px;
            color: #000000;
            margin-top: 60px;
        }
    </style>
    </br>
    <p>Get ready for an exhilarating tech extravaganza! TECHSTORM 2023
      
    </p>
   &nbsp&nbsp&nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
     <a href="Registration.aspx" class="cta-button">Register Now!</a>
      
    <div class="guidelines">
        <h2>Guidelines for Participating College Students:</h2>
        <ul>
            <li>Form a team of talented individuals and choose a captivating team name.</li>
            <li>Explore the latest trends and technologies to bring innovation to your project.</li>
            <li>Collaborate, brainstorm, and unleash your creativity to build a cutting-edge tech solution.</li>
            <li>Prepare a captivating presentation to showcase the features and benefits of your project.</li>
            <li>Be open to learning from industry experts and interacting with fellow participants.</li>
            <li>Stay committed, work as a team, and have a positive attitude throughout the event.</li>
            <li>Embrace the spirit of healthy competition and showcase your skills with confidence.</li>
            <li>Follow the rules and guidelines provided by the event organizers at all times.</li>
            <li>Above all, have fun, make new connections, and create memorable experiences!</li>
        </ul>
    </div>
 </asp:Content>