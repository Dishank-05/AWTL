<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Angular.aspx.cs" Inherits="Prac4_2_Angular.Angular" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<title></title>
<script type="text/javascript"
src="https://ajax.googleapis.com/ajax/libs/angularjs/1.6.9/angular.min.js"></script>
<style type="text/css">
.auto-style1 {
width: 50%;
height: 100%;
}
</style>
</head>
<body ng-app="myApp">
<div ng-controller="myCtrl">
<table class="auto-style1">
<tr>
<td>
<h3>UnOrdered</h3>
</td>
<td>
<h3>Ordered Filter: By id</h3>
</td>
</tr>
<tr>
<td>
<table border="1" cellspacing="0" cellpadding="5">
<thead>
<th>Id</th>
<th>Name</th>
<th>Salary</th>
<th>Date of joining</th>
</thead>
<tr ng-repeat="x in emp">
<td>{{x.id}}</td>
<td>{{x.name}}</td>
<td>{{x.sal}}</td>
    <td>{{x.doj}}</td>
</tr>
</table>
</td>
<td>
<table border="1" cellspacing="0" cellpadding="5">
<thead>
<th>Id</th>
<th>Name</th>
<th>Salary</th>
<th>Date of joining</th>
</thead>
<tr ng-repeat="x in emp | orderBy: 'id'">
<td>{{x.id}}</td>
<td>{{x.name}}</td>
<td>{{x.sal}}</td>
<td>{{x.doj}}</td>
</tr>
</table>
</td>
</tr>
</table>
<h3>Number filter</h3>
<ul>
<li ng-repeat="x in emp">Salary of {{x.name}} is {{ x.sal | number:3}}</li>
</ul>
<h3>Currency filter</h3>
<ul>
<li ng-repeat="x in emp">Salary of {{x.name}} is {{x.sal|currency:'Rs.'}}</li>
</ul>
</div>
<script>
    var app = angular.module("myApp", []);
    app.controller("myCtrl", function ($scope) {
        $scope.emp = [
        { id: '102', name: 'Rushikesh', sal: '50000', doj: '19-01-2018' }, { id: '103', name:
        'Sakshi', sal: '400000', doj: '15-02-2018' }, { id: '101', name: 'Avantika', sal: '520000', doj: '18-05-2022' }]
        });
</script>
</body>
</html>