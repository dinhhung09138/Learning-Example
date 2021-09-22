
function writeLog(msg) {
    console.log(msg);
    return 1;
}

function callStaticMethod() {
    DotNet.invokeMethodAsync("Component", "StaticMethod");
}

function callInstanceMethod(dotNetReference) {
    dotNetReference.invokeMethodAsync("InstanceMethod");
}