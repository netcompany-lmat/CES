export interface EstimateRoutesResponse{
  routes: EstimatedRoute[]
}

export interface EstimatedRoute {
  uniqueID: number
  option: string
  price: number
  time: number
}
