export async function getdefault(){
    const response =await fetch('/api/getdefault');
    return await response.json();
  
}

export async function GetCircle(_color){
const data={'color':_color};

    const response =await fetch('/api/GetCircle',{
method:'POST',
headers:{'Content-Type':'application/json'},
body:JSON.stringify(data)

    });
    return await response.json();
  
}