
var LoginVueObj=new Vue({
    el: '#LoginDiv',
    data: {
        UserName: "",
        UserPassword: "",
        Messages: {
            Success: "",
            Failure: "",
            ValidationMessage:""
        },
        LoginURL:""
    },
    methods: {
        IsNullorEmpty: function (o) {
            if (o == null || o == "" || o == undefined)
                return true;
            else
                return false;
        },
        LoginUser: function () {
            var isEmpty = this.IsNullorEmpty(this.UserName) || this.IsNullorEmpty(this.UserPassword);
            if (!isEmpty) {
                var postObj = { UserName: this.UserName, UserPassword: this.UserPassword };
                console.log(postObj);
                swal({
                    title: 'Custom animation with Animate.css',
                    showClass: {
                        popup: 'animate__animated animate__fadeInDown'
                    },
                    hideClass: {
                        popup: 'animate__animated animate__fadeOutUp'
                    }
                });
            }
        }
    }
});