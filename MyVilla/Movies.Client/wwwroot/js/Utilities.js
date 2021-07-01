
function writeLog(message) {
    console.log(message);
}

function dotnetStaticInvocation() {
    DotNet.invokeMethodAsync("Movies.Client", "GetStaticCounter").then(result => {
        console.log("static value " + result);
    });
}

function dotNetInstanceInvocation(instance) {
    instance.invokeMethodAsync("IncrementCount");
}