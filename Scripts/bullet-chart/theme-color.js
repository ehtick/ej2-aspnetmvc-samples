﻿function loadBulletChartTheme(args) {
    var selectedTheme = location.hash.split('/')[1];
    selectedTheme = selectedTheme ? selectedTheme : 'Tailwind3';
    args.bulletChart.theme = (selectedTheme.charAt(0).toUpperCase() +
        selectedTheme.slice(1)).replace(/-dark/i, 'Dark').replace(/light/i, 'Light').replace(/contrast/i, 'Contrast').replace(/-highContrast/i, 'HighContrast');
};

var fabricColors = ['#e269ae', '#6f6fe2', '#c1c1c1', '#5b9bd5', '#70ad47', '#ffc000', '#ed7d31', '#4472c4'];
var bootstrapColors = ['#407c92', '#b99b4f', '#7953ac', '#ff6ea6', '#7ddf1e', '#55a5c2', '#f7ce69', '#a16ee5'];
var highContrastColors = ['#43ACEF', '#00C27A', '#FA83C3', '#BA98FF', '#C6E773',
    '#DFE6B6', '#E98272', '#79ECE4'];
var materialColors = ['#63C7FF', '#8A77FF', '#F45C5C', '#EBBB3E', '#61EAA9', '#C57AFF', '#56AEFF', '#9ECB08'];
var bootstrapDarkColors = ['#407c92', '#8A77FF', '#7953ac', '#ff6ea6', '#7ddf1e',
    '#55a5c2', '#f7ce69', '#a16ee5'];
var tailwindColors = ['#9333EA', '#F97316', '#0369A1', '#8B5CF6', '#14B8A6', '#334155', '#65A30D', '#5A61F6'];
var tailwindDarkColors = ['#2DD4BF', '#F97316', '#FCD34D', '#E879F9', '#4ADE80', '#F87171', '#22D3EE', '#8B5CF6'];
var tailwind3Colors = ['#2F4074', '#03B4B4', '#0D72DE', '#FF5733', '#D63384', '#F39C12', '#EF291F', '#91C822'];
var tailwind3DarkColors = ['#8029F1', '#1ABC9C', '#0D72DE', '#FF5733', '#D63384', '#F39C12', '#EF291F', '#91C822'];
var bootstarp5Colors = ['#C9E422', '#FD7400', '#4BE0BC', '#963C70', '#F7523F', '#2196F5', '#FFB400', '#6355C7'];
var bootstarp5DarkColors = ['#ECFF77', '#FCAA65', '#63F5D2', '#FF6DB3', '#FF7F71', '#6CBDFF', '#FFD46D', '#8F80F4'];
var fluentColors = ['#5887FF', '#EE993D', '#1BD565', '#FF7266', '#AF4BCF', '#EDBB40', '#DA4CB2', '#1AC9E6'];
var material3Colors = ['#2196F5', '#4BE0BC', '#FD7400', '#963C70', '#F7523F', '#FFB400', '#00AEE0', '#6355C7'];
var material3DarkColors = ['#B93CE4', '#B3F32F', '#FF9E45', '#38FFE7', '#17EA58', '#FFF500', '#FA4EAB', '#4EAAFF'];
var defaultColors = ['#7f84e8', '#dd8abd', '#70ad47', '#f8b883', '#e56590', '#357cd2', '#404041', '#00bdae'];
var fluent2Colors = ["#6200EE", "#09AF74", "#0076E5", "#CB3587", "#E7910F", "#0364DE", "#66CD15", "#F3A93C", "#107C10", "#C19C00"];
var fluent2DarkColors = ["#9BB449", "#2A72D5", "#43B786", "#3F579A", "#584EC6", "#E85F9C", "#6E7A89", "#EA6266", "#0B6A0B", "#C19C00"];
var fluent2HighContrastColors = ["#9BB449", "#2A72D5", "#43B786", "#3F579A", "#584EC6", "#E85F9C", "#6E7A89", "#EA6266", "#0B6A0B", "#C19C00"];