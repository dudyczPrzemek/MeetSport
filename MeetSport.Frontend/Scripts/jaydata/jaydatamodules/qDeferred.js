// JayData 1.5.0 CTP
// Dual licensed under MIT and GPL v2
// Copyright JayStack Technologies (http://jaydata.org/licensing)
//
// JayData is a standards-based, cross-platform Javascript library and a set of
// practices to access and manipulate data from various online and offline sources.
//
// Credits:
//     Hajnalka Battancs, Dániel József, János Roden, László Horváth, Péter Nochta
//     Péter Zentai, Róbert Bónay, Szabolcs Czinege, Viktor Borza, Viktor Lázár,
//     Zoltán Gyebrovszki, Gábor Dolla
//
// More info: http://jaydata.org
(function(f){if(typeof exports==="object"&&typeof module!=="undefined"){module.exports=f()}else if(typeof define==="function"&&define.amd){define([],f)}else{var g;if(typeof window!=="undefined"){g=window}else if(typeof global!=="undefined"){g=global}else if(typeof self!=="undefined"){g=self}else{g=this}g.$data = f()}})(function(){var define,module,exports;return (function e(t,n,r){function s(o,u){if(!n[o]){if(!t[o]){var a=typeof require=="function"&&require;if(!u&&a)return a(o,!0);if(i)return i(o,!0);var f=new Error("Cannot find module '"+o+"'");throw f.code="MODULE_NOT_FOUND",f}var l=n[o]={exports:{}};t[o][0].call(l.exports,function(e){var n=t[o][1][e];return s(n?n:e)},l,l.exports,e,t,n,r)}return n[o].exports}var i=typeof require=="function"&&require;for(var o=0;o<r.length;o++)s(r[o]);return s})({1:[function(require,module,exports){
(function (global){
'use strict';

Object.defineProperty(exports, "__esModule", {
    value: true
});

var _core = require('jaydata/core');

var _core2 = _interopRequireDefault(_core);

var _q = (typeof window !== "undefined" ? window['Q'] : typeof global !== "undefined" ? global['Q'] : null);

var q = _interopRequireWildcard(_q);

function _interopRequireWildcard(obj) { if (obj && obj.__esModule) { return obj; } else { var newObj = {}; if (obj != null) { for (var key in obj) { if (Object.prototype.hasOwnProperty.call(obj, key)) newObj[key] = obj[key]; } } newObj.default = obj; return newObj; } }

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

(function ($data) {
    $data.Class.define('$data.Deferred', $data.PromiseHandlerBase, null, {
        constructor: function constructor() {
            this.deferred = new q.defer();
        },
        deferred: {},
        createCallback: function createCallback(callBack) {
            callBack = $data.typeSystem.createCallbackSetting(callBack);
            var self = this;

            return {
                success: function success() {
                    callBack.success.apply(self.deferred, arguments);
                    self.deferred.resolve.apply(self.deferred, arguments);
                },
                error: function error() {
                    Array.prototype.push.call(arguments, self.deferred);
                    callBack.error.apply(self.deferred, arguments);
                    /*self.deferred.reject.apply(self.deferred, arguments);
                      var finalErr;
                      try{
                        callBack.error.apply(self.deferred, arguments);
                        try{
                            self.deferred.reject.apply(self.deferred, arguments);
                        }catch(err){
                            finalErr = err;
                        }
                    }catch(err){
                        finalErr = arguments[0];
                        try{
                            self.deferred.reject.apply(self.deferred, arguments);
                        }catch(err){
                            finalErr = err;
                        }
                    }
                      if (finalErr){
                        //throw finalErr;
                    }*/
                }
            };
        },
        getPromise: function getPromise() {
            return this.deferred.promise;
        }
    }, null);

    $data.PromiseHandler = $data.Deferred;
})(_core2.default);

exports.default = _core2.default;
module.exports = exports['default'];

}).call(this,typeof global !== "undefined" ? global : typeof self !== "undefined" ? self : typeof window !== "undefined" ? window : {})

},{"jaydata/core":"jaydata/core"}]},{},[1])(1)
});

