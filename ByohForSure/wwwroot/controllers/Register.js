
var RegisterVueObj = new Vue({
    el: '#RegisterDiv',
    data: {
        UserName: "",
        UserPassword: "",
        UserEmail: "",
        AgeDate: "",
        AgeMonth: "",
        AgeYear: "",
        Gender:"Male",
        Messages: {
            Success: "",
            Failure: "",
            ValidationMessage: ""
        },
        LoginURL: ""
    },
    methods: {
        IsNullorEmpty: function (o) {
            if (o == null || o == "" || o == undefined)
                return true;
            else
                return false;
        },
        CheckEmailExist: function () { },
        LoginUser: function () {
            var isEmpty = this.IsNullorEmpty(this.UserName) || this.IsNullorEmpty(this.UserPassword);
            var DOB = this.AgeDate + "/" + this.AgeMonth + "/" + this.AgeYear;
            var Gender = this.Gender;
            if (!isEmpty) {
                var postObj = { UserName: this.UserName, UserPassword: this.UserPassword, UserEmail: this.UserEmail, DOB:DOB };
                
                console.log(postObj);
                swal({
                    title: 'Custom animation with Animate.css',
                    showClass: {
                        popup: 'animate__animated animate__fadeInDown'
                    },
                    hideClass: {
                        popup: 'animate__animated animate__fadeOutUp'
                    }
                })
            }
        }
    }
});