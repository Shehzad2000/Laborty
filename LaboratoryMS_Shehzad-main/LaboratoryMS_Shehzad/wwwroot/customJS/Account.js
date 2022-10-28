var BaseHostedURL = 'http://localhost:59979/api/';

$(document).ready(function () {
    
});

function Register() {
    var AdminObj = {
        AdminID: $('#AdminID').val(),
        Name: $('#Name').val(),
        Email: $('#Email').val(),
        Contact: $('#Contact').val(),
        Password: $('#Password').val(),
        Image: $('#Image').val()
    }
   
    $.ajax({
        url:,
        data: JSON.stringify(AdminObj),
        type:"Post",
        contentType:"application/json;charset=utf-8",
        dataType:"JSON",
        success: function (result) {
            
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    })
};
function Login() {
    var useremail = $('#txtEmail').val();
    var password = $('#txtPassword').val();
    $.ajax({
        url: BaseHostedURL+'Account/login',
        data: JSON.stringify('{Email:"' + useremail + '",Password:"' + password + '"}'),
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        succuss: function (result) {
            if (result != "") {
                return true;
            }
            else {
                return false;
            }
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}