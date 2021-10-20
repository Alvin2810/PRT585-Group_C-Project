export interface actorCreationDTO{ 
    name: string;
    dateOfBirth: Date;
    biography: string;
    picture: File;
    
}

export interface actorDTO {
    name: string;
    dateOfBirth: Date;
    biography: string;
    picture: any;    
}