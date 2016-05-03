angular.module('starter').filter('idadeFilter', function () {
    function calculateAge(birthday) { // birthday is a date
        var ageDifMs = Date.now() - birthday.getTime();
        var ageDate = new Date(ageDifMs); // miliseconds from epoch
        return Math.abs(ageDate.getUTCFullYear() - 1970);
    }
    function monthDiff(d1, d2) {
        if (d1 < d2){
            var months = d2.getMonth() - d1.getMonth();
            return months <= 0 ? 0 : months;
        }
        return 0;
    }       
    return function (birthdate) {
        if (typeof birthdate != 'object')
            birthdate = new Date(birthdate);
        var age = calculateAge(birthdate);
        if (age == 0)
            return monthDiff(birthdate, new Date()) + ' Meses';
        return age;
    }; 
})

.directive('convertToNumber', function () {
    return {
        require: 'ngModel',
        link: function (scope, element, attrs, ngModel) {
            ngModel.$parsers.push(function (val) {
                return parseInt(val, 10);
            });
            ngModel.$formatters.push(function (val) {
                return '' + val;
            });
        }
    }
});