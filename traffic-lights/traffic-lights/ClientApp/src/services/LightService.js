
export const getDefault =async () => {    
    const response = await fetch('/lights/get_default');
    return await response.json();
}


export const getCircle =async (color) => {
    const data = { 'color': color };
    const response = await fetch('/lights/get_circle', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify(data)

    });
    return await response.json();
}
