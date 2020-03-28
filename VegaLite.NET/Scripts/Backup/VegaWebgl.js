
            var copyDataToBuffer = function(iD, csharpVariable) {

                if (vega_datasets[`dataset_${iD}`]) {

                    const rows = vega_datasets[`dataset_${iD}`].rows;
                    const columns = vega_datasets[`dataset_${iD}`].columns;

                    if (rows === 0 || columns === 0) {
                        return csharpVariable;
                    }

                    const n = rows * columns;

                    const data = new Float32Array(n);

                    const sizeOfData = data.length * data.BYTES_PER_ELEMENT;

                    var index = 0;

                    for (var i = 0; i < csharpVariable.length; ++i) {
                        const obj = csharpVariable[i];
                        for (const key in obj) {
                            data[index++] = obj[key];
                        }
                    }

                    var vis_element = document.getElementById(`vis-${iD}`);

                    var canvas = vis_element.firstElementChild;

                    var gl = canvas.getContext("webgl");

                    const buffer = gl.createBuffer();

                    gl.bindBuffer(gl.ARRAY_BUFFER, buffer);

                    gl.bufferData(gl.ARRAY_BUFFER, sizeOfData, gl.STATIC_DRAW); //gl.DYNAMIC_DRAW

                    gl.bufferSubData(gl.ARRAY_BUFFER, 0, data);

                    gl.bindBuffer(gl.ARRAY_BUFFER, 0);

                    return data;
                }

                return csharpVariable;
            };

            var updateViewDataId = function(iD) {

                interactive.csharp.getVariable(`dataset_${iD}`).then(
                    function (csharp_variable) {

                        console.log(csharp_variable);

                        try {
                            const data = copyDataToBuffer(`dataset_${iD}`, csharp_variable);
                            result.view.data(`${iD}`, data);
                        } catch (err) {
                            console.log(err);
                        }

                        result.view.data(`${iD}`, csharp_variable);
                    });
            };
