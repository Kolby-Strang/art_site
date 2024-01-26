export class Sculpture {
    constructor(data) {
        this.name = data.name
        this.coverImg = data.coverImg
        this.createdAt = Date(data.createdAt)
        this.updatedAt = Date(data.updatedAt)
        this.description = data.description
        this.id = data.id
        this.isLarge = data.isLarge
        this.price = data.price
        this.year = data.year
    }
}