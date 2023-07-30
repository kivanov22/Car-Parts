
export interface Part {
    partName:string,
    partDescription:string,
    partNumber:number,
    manufacturer:string,
    condition:string,
    material:string,
    size:number,
    coverImage:string,
    images:string[],
    category:string,
    make:string,
    model:string,
    price:number,
}

// Define action types
export enum ActionTypes {
    CHANGE_INPUT = 'CHANGE_INPUT',
    ADD_IMAGES = 'ADD_IMAGES',
  }
  
  // Define action interfaces
  export interface ChangeInput {
    type: ActionTypes.CHANGE_INPUT;
    payload: {field:keyof Part;value:any};
  }
  

//   export interface AddImages {
//     type:ActionTypes.ADD_IMAGES;
//     payload:
//   }
  
  export type Action = ChangeInput;