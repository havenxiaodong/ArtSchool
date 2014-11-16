/**
 * Created by Colin on 14-5-26.
 */
define(function(require, exports, module) {
    var $ = require('libs/jquery/jquery.js'); // 使用jquery
    var font=$('.fontIcon').find('i');
    var triangle=$('.triangle').find('div');
    var num=font.length;
    for(var i=0;i<num;i++){
        font.get(i).index=i;
        font.get(i).onmouseover=function(){
           var index=this.index;
            block(index,triangle);
        };
        font.get(i).onmouseout=function(){
            for(var i=0;i<num;i++){
                triangle.eq(i).css('visibility','hidden');
            }
        }

    }
   function block(index,htmlCollection){
        var num=htmlCollection.length;
        for(var i=0;i<num;i++){
            htmlCollection.eq(i).css('visibility','hidden');
        }
         htmlCollection.eq(index).css('visibility','visible');
    }


});
