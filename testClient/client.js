/// <reference path="library/jquery.js" />
$(document).ready(function () {
    $('#createAccountBtn').click(function () {
        console.log('Create Account Clicked...');
        $.ajax({
            type: "PUT",
            contentType: "application/json",
            url: "/api/CreateAccount",
            dataType: "json",
            data: JSON.stringify({
                firstName: 'Jessica',
                lastName: 'Angres',
                accountNumber: '',
                gender:1
            }),
            success: function (data) {
                console.log(data);
            },
            error: function (data) {
                console.log(data);
            }
        });
    });

    $('#deleteAccountBtn').click(function () {
        console.log('Delete Account Clicked...');
        $.ajax({
            type: "DELETE",
            contentType: "application/json",
            url: "/api/DeleteAccount",
            dataType: "json",
            data: JSON.stringify({
                firstName: 'Jessica',
                lastName: 'Angres',
                accountNumber: '78672376373838828',
                gender: 1
            }),
            success: function (data) {
                console.log(data);
            },
            error: function (data) {
                console.log(data);
            }
        });
    });

    $('#updateAccountBtn').click(function () {
        console.log('Update Account Clicked...');
        $.ajax({
            type: "POST",
            contentType: "application/json",
            url: "/api/UpdateAccount",
            dataType: "json",
            data: JSON.stringify({
                firstName: 'Jessica',
                lastName: 'Angres',
                accountNumber: '78672376373838828',
                gender: 0
            }),
            success: function (data) {
                console.log(data);
            },
            error: function (data) {
                console.log(data);
            }
        });
    });

    $('#getAccountBtn').click(function () {
        console.log('Get Account Clicked...');
        $.ajax({
            type: "GET",
            contentType: "application/json",
            url: "/api/Account/" + '8377738',
            dataType: "json",
            success: function (data) {
                console.log(data);
            },
            error: function (data) {
                console.log(data);
            }
        });
    });
});