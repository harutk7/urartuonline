/*! Select2 4.0.11 | https://github.com/select2/select2/blob/master/LICENSE.md */

!function(){if(jQuery&&jQuery.fn&&jQuery.fn.select2&&jQuery.fn.select2.amd)var n=jQuery.fn.select2.amd;n.define("select2/i18n/am",[],function(){function n(n,e,r,u){return n%10<5&&n%10>0&&n%100<5||n%100>20?n%10>1?r:e:u}return{errorLoading:function(){return"Անհնար է ներբեռնել որոնման արդյունքները"},inputTooLong:function(e){var r=e.input.length-e.maximum,u="Մուտքագրեք "+r;return u+=n(r,"","","ից"),u+=" քիչ նիշ"},inputTooShort:function(e){var r=e.minimum-e.input.length,u="Մուտքագրեք առնվազն "+r+" նիշ";return u+=n(r,"","","")},loadingMore:function(){return"Արդյունքների ներբեռնում…"},maximumSelected:function(e){var r="Թույլատրվում է ընտրել առնվազն "+e.maximum+" տարր";return r+=n(e.maximum,"","","")},noResults:function(){return"Ոչինչ չի հայտնաբերվել"},searching:function(){return"Որոնում…"},removeAllItems:function(){return"Հեռացնել բոլոր տարրերը"}}}),n.define,n.require}();